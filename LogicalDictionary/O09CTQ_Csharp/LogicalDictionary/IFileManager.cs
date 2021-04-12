using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDictionary
{
    public interface IFileManager
    {
        void SetMainDirectory(string RelativePath);
        string LastModified();
        void OpenTxt(string Path);
        SortedDictionary<string, string> ReadAllFiles();
    }
}

