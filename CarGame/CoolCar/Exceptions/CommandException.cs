using CoolCar.Models;

namespace CoolCar.Exceptions
{
    public class CommandException : Exception
    {
        public readonly ICommand _command;
        public readonly Exception _exception;

        public CommandException(ICommand command)
        {
            _command = command;
            _exception = this;
        }
        public CommandException(ICommand command, Exception exception)
        {
            _command = command;
            _exception = exception;
        }
    }
}
