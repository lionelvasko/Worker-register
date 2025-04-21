using Dolgozó_nyilvántartó.Database;
using Dolgozó_nyilvántartó.Database.Controllers;
using Dolgozó_nyilvántartó.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozó_nyilvántartó.Applciation
{
    internal class ListWorkersCommand : ICommand
    {
        private readonly IController _controller;
        public string Name => "ListWorkers";

        public ListWorkersCommand(IController controller)
        {
            _controller = controller;
        }

        public void Execute(IHost host, string[] args)
        {
            var workers = _controller.ListAll();
            foreach (var worker in workers)
            {
                host.WriteLine(worker.Name);
            }
        }
    }
}
