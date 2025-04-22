using Dolgozó_nyilvántartó.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozó_nyilvántartó.UserInterface
{
    internal class UI : ICLI
    {
        private readonly IHost _host;
        private readonly CommandProvider _commandProvider;
        public UI(IHost host, CommandProvider commandProvider)
        {
            _host = host;
            _commandProvider = commandProvider;
        }

        public void Run()
        {
            while (true)
            {
                string input = _host.ReadLine();
                string[] splittedInput = input.Split(' ');
                ICommand? commandToExecute = FindCommandbyName(splittedInput[0]);

                if (commandToExecute == null)
                {
                    _host.WriteLine($"Command '{splittedInput[0]}' not found.");
                    continue;
                }

                try
                {
                    commandToExecute.Execute(_host, splittedInput[1..]);
                }
                catch (Exception ex)
                {
                    _host.WriteLine(ex.Message);
                }
            }
        }

        private ICommand? FindCommandbyName(string name)
        {
            foreach (var command in _commandProvider.Commands)
            {
                if (command.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    return command;
                }
            }
            return null;
        }
    }
}
