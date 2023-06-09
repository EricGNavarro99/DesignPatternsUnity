using System.Collections.Generic;
using System.Threading.Tasks;

namespace Unity.Commander
{
    public class CommandQueue
    {
        public static CommandQueue Instance => instance ?? (instance = new CommandQueue());

        private readonly Queue<ICommand> commandsToExecute;
        private bool runningCommand;
        private static CommandQueue instance;

        public CommandQueue()
        {
            this.commandsToExecute = new Queue<ICommand>();
            this.runningCommand = false;
        }

        public void AddCommand(ICommand commandToEnqueue)
        {
            this.commandsToExecute.Enqueue(commandToEnqueue);
            RunNextCommand().WrapErrors();
        }

        private async Task RunNextCommand()
        {
            if (this.runningCommand) return;

            while (this.commandsToExecute.Count > 0)
            {
                this.runningCommand = true;

                var commandToExecute = this.commandsToExecute.Dequeue();
                await commandToExecute.Execute();
            }

            this.runningCommand = false;
        }

    }
}

public static class TaskExtension
{
    public static async void WrapErrors(this Task task) => await task;
}