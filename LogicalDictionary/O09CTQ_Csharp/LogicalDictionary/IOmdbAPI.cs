using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDictionary
{
    public interface IOmdbAPI
    {
        void GetOmdbData(string Title, string Year);

    }
}
