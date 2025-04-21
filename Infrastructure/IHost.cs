using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozó_nyilvántartó.Infrastructure
{
    internal interface IHost
    {
        public void Exit();
        public string ReadLine();
        public void WriteLine(string meaasge);
        public void Write(string message);
    }
}
