using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System
{
    public interface IFiles
    {
        string DataString();
    }

    public delegate void SaveDelegate<T>(T obj, string filePath) where T : IFiles;
}
