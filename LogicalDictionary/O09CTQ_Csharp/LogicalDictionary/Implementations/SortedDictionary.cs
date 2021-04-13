using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDictionary.Implementations
{
    public class SortedDictionary : ISortedDictionary
    {
        private SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>();

        public SortedDictionary(SortedDictionary<string, string> sortedDictionary)
        {
            this.sortedDictionary = sortedDictionary;
        }

        public void AddNewItem(string Title, string Year)
        {
            try
            {
                sortedDictionary.Add(Title, Year);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with this Key already exists.");
            }
        }

        public void DeleteAll()
        {
            sortedDictionary.Clear();
        }

        public int EveryItem()
        {
            throw new NotImplementedException();
        }

        public void ExistingItem(string Title)
        {
            throw new NotImplementedException();
        }

        public void GetValueByKey(string Title, string Year)
        {
            throw new NotImplementedException();
        }

        public bool YearInDictionary(string Year)
        {
            bool ExistingItem = sortedDictionary.ContainsValue(Year);
            if (!ExistingItem)
            {
                return false;
            }
            return true;
        }
    }
}
