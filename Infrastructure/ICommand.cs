using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozó_nyilvántartó.Infrastructure
{
    internal interface ICommand
    {
        string Name { get; }
        void Execute(IHost host, string[] args);
    }
}
