using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LogicalDictionary.Implementations
{
    public class FileManager : IFileManager
    {
        private string Folder { get; set; }
        private string GivenFile { get; set; }
        private IOmdbAPI omdbAPI;
        public FileManager(string folder, string givenFile)
        {
            Folder = folder;
            GivenFile = givenFile;
        }

        public DateTime LastModified()
        {
            DateTime dt = File.GetLastWriteTime(GivenFile);
            return dt;
        }

        public SortedDictionary<string, string> ReadAllFiles()
        {
            SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>();

            foreach (string file in Directory.EnumerateFiles(Folder, "*.txt"))
            {
                string contents = Path.GetFileNameWithoutExtension(file);
                Console.WriteLine(contents);
                
                
                string[] items = contents.Split(' ');
                foreach (string item in items)
                {
                    string[] keyValue = item.Split('-');
                    sortedDictionary.Add(keyValue[0], keyValue[1]);
                }
            
            }
           return sortedDictionary;
            
        }

        public void SetMainDirectory(string RelativePath)
        {
            this.GivenFile = RelativePath;
        }

        public void SaveOmdbData(SortedDictionary<string, string> Dictionary)
        {
            StreamWriter sw = new StreamWriter(GivenFile);
            
            foreach (KeyValuePair<string, string> pair in Dictionary)
            {
                Console.WriteLine("Title: {0} and Year: {1} has been found", pair.Key, pair.Value);
                omdbAPI = new OmdbAPI(pair.Key, pair.Value);

                FilmModel result = omdbAPI.JsonConvertByResult(omdbAPI.GetOmdbData());  
                try {
                    sw.Write(result.ToString());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }  
            }
            sw.Close();
        }
    }
}
