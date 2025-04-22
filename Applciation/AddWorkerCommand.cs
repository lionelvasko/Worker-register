using Dolgozó_nyilvántartó.Database.Controllers;
using Dolgozó_nyilvántartó.DTO;
using Dolgozó_nyilvántartó.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozó_nyilvántartó.Applciation
{
    internal class AddWorkerCommand : ICommand
    {
        public string Name => "AddWorker";
        private readonly IController _controller;

        public AddWorkerCommand(IController controller)
        {
            _controller = controller;
        }

        public void Execute(IHost host, string[] args)
        {
            Worker worker = new Worker()
            {
                Name = args[0],
                Email = args[1],
                Age = Convert.ToInt32(args[2]),
                Salary = Convert.ToDecimal(args[3]),
            };
            _controller.AddOne(worker);
            
        }
    }
}
