using LogicalDictionary.Implementations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalDictionary
{
    public interface IFileManager 
    {
        void SetMainDirectory(string RelativePath);
        DateTime LastModified();
        void OpenTxt(SortedDictionary<string, string> Dictionary);
        SortedDictionary<string, string> ReadAllFiles();
        
    }
}

