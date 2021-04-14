using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDictionary
{
    public interface IOmdbAPI
    {
        string GetOmdbData();

        FilmModel JsonConvertByResult(string Result);
    }
}
