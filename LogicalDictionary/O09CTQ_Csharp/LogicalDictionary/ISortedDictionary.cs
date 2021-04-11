using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDictionary
{
    public interface ISortedDictionary
    {
        void AddNewItem(string Title, string Year);

        void DeleteAll();

        void GetValueByKey(string Title, string Year);

        void ExistingItem(string Title);

        int EveryItem();

        bool YearInDictionary();
    }
}
