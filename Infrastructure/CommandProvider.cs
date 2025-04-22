using Dolgozó_nyilvántartó.Applciation;

namespace Dolgozó_nyilvántartó.Infrastructure
{
    internal class CommandProvider
    {
        public ICommand[] Commands { get; }

        public CommandProvider(IController controller, IFileManager fileManager)
        {
            Commands = new ICommand[]{
                new ExitCommand(),
                new ListWorkersCommand(controller),
                new ExportWorkersCommand(controller, fileManager),
                new AddWorkerCommand(controller)
            };
        }


    }
}
