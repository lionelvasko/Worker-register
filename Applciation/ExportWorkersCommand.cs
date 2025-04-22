using Dolgozó_nyilvántartó.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozó_nyilvántartó.Applciation
{
    internal class ExportWorkersCommand : ICommand
    {
        private IController _controller;
        private IFileManager _fileManager;
        private IHost _host;
        public string Name => "ExportWorkers";

        public ExportWorkersCommand(IController controller, IFileManager fileManager)
        {
            _controller = controller;
            _fileManager = fileManager;
        }

        public void Execute(IHost host, string[] args)
        {
            var workers = _controller.ListAll();
            var content = new StringBuilder();

            if (workers.Any())
            {
                foreach (var worker in workers)
                {
                    content.AppendLine(worker.Name);
                }
                _fileManager.WriteToFile(args[0], content.ToString());
            }
        }
    }
}
