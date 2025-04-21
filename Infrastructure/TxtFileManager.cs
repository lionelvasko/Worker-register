using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozó_nyilvántartó.Infrastructure
{
    // SOLID elvek talán sérti a Single Responsibility-t
    internal class TxtFileManager : IFileManager
    {
        public string FileDirectory => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;
        public string FileExtension => ".txt";

        public TxtFileManager()
        {
            
            Console.WriteLine(FileDirectory);
        }

        public void AppendFile(string fileName, string content)
        {
            string fullPath = Path.Combine(FileDirectory, fileName + FileExtension);
            if (!FileExists(fileName))
            {
                CreateFile(fileName);
            }
            using (StreamWriter streamWriter = new StreamWriter(fullPath, append: true))
            {
                streamWriter.WriteLine(content);
            }
        }

        public void CreateFile(string fileName)
        {
            string fullPath = Path.Combine(FileDirectory, fileName + FileExtension);
            if (!FileExists(fileName))
            {
                File.Create(fullPath).Dispose();
            }
        }

        public void DeleteFile(string fileName)
        {
            if (FileExists(fileName))
            {
                string fullPath = Path.Combine(FileDirectory, fileName + FileExtension);
                File.Delete(fullPath);
            }
        }

        public bool FileExists(string fileName)
        {
            string fullPath = Path.Combine(FileDirectory, fileName + FileExtension);
            return File.Exists(fullPath);
        }

        public string ReadFromFile(string fileName)
        {
            throw new NotImplementedException();
        }

        public void WriteToFile(string fileName, string content)
        {
            throw new NotImplementedException();
        }
    }
}
