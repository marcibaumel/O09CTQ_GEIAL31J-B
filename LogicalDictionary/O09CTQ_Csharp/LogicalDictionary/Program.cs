using LogicalDictionary.Implementations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Films";
            string resultPath = @"Result.txt";
            string fullPath = Path.GetFullPath(path);
            string fullPathResult = Path.GetFullPath(resultPath);
            
            /**
             * Absolute reach
             */

            //IFileManager fileManager = new FileManager(@"D:\WORK\EGYETEM\4 FÉLÉV\Repos\CsharpBeadndó\LogicalDictionary\O09CTQ_Csharp\LogicalDictionary\Films\", @"D:\WORK\EGYETEM\4 FÉLÉV\Repos\CsharpBeadndó\LogicalDictionary\O09CTQ_Csharp\LogicalDictionary\Result.txt");

            
            IFileManager fileManager = new FileManager(fullPath, fullPathResult);

            Console.WriteLine("Founded movies on your given directory: \n");

            ISortedDictionary sortedDictionary = new SortedDictionary(fileManager.ReadAllFiles());

            Console.WriteLine($"\nIn number:{sortedDictionary.CountMySortedDictionary()}");

            string newKey = "Mank";
            string newValue = "2020";
            Console.WriteLine($"\nManually given movie: {newKey}\n");

            sortedDictionary.AddNewItem(newKey, newValue);
            fileManager.SaveOmdbData(sortedDictionary.getDictionary());

            Console.WriteLine("\nThere is a movie which released in 1980?");
            Console.WriteLine("The answer is: " + sortedDictionary.YearInDictionary("1970"));

            Console.WriteLine("\nThere is a movie which called Mank?");
            Console.WriteLine("The answer is: " + sortedDictionary.ExistingItem("Mank"));

            Console.WriteLine("\nThis movies are made in 2020:");
            sortedDictionary.GetKeyByValue("2020");

            Console.WriteLine("\nDelete every item from the SortedDictionary, new value in number: ");
            sortedDictionary.DeleteMySortedDictionary();
            Console.WriteLine(sortedDictionary.CountMySortedDictionary());

            Console.WriteLine("\nPress enter (END)");
            Console.ReadLine();

        }
    }
}
