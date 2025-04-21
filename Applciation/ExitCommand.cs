using Dolgozó_nyilvántartó.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozó_nyilvántartó.Applciation
{
    internal class ExitCommand : ICommand
    {
        public string Name => "Exit";

        public void Execute(IHost host, string[] args)
        {
            host.Exit();
        }
    }
}
