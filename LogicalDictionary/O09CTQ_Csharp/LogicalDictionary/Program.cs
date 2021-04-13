using LogicalDictionary.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IFileManager fileManager = new FileManager(@"D:\WORK\EGYETEM\4 FÉLÉV\Repos\CsharpBeadndó\LogicalDictionary\O09CTQ_Csharp\LogicalDictionary\Films\", @"D:\WORK\EGYETEM\4 FÉLÉV\Repos\CsharpBeadndó\LogicalDictionary\O09CTQ_Csharp\LogicalDictionary\Films\Result.txt");
            ISortedDictionary sortedDictionary = new SortedDictionary(fileManager.ReadAllFiles());
           
            IOmdbAPI omdbAPI = new OmdbAPI();

            fileManager.OpenTxt(sortedDictionary.getDictionary());

            Console.ReadLine();

        }
    }
}
