using CoolCar.Exceptions;
using CoolCar.Models;

namespace CoolCar.Commands
{
    public class MacroCommand : ICommand
    {
        private ICommand[] _commandsArray;
        public MacroCommand(ICommand[] commands)
        {
            _commandsArray = commands ?? throw new ArgumentNullException(nameof(commands));
        }

        public void Execute()
        {
            foreach (ICommand command in _commandsArray)
            {
                try
                {
                    command.Execute();
                }
                catch (Exception ex)
                {
                    throw new CommandException(command, ex);
                }
            }
        }

    }
}
