using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozó_nyilvántartó.Infrastructure
{
    internal interface IFileManager
    {
        internal string FileDirectory { get; }
        internal string FileExtension { get; }
        void CreateFile(string fileName);
        void AppendFile(string fileName, string content);
        void WriteToFile(string fileName, string content);
        string ReadFromFile(string fileName);
        void DeleteFile(string fileName);
        bool FileExists(string fileName);

    }
}
