using Dolgozó_nyilvántartó.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozó_nyilvántartó.UserInterface
{
    internal class Host : IHost
    {
        public void Exit() => Environment.Exit(0);

        public string ReadLine() => Console.ReadLine() ?? string.Empty;

        public void Write(string message) => Console.Write(message);

        public void WriteLine(string message) => Console.WriteLine(message);
    }
}
