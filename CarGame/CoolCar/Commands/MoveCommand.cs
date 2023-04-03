using CoolCar.Models;

namespace CoolCar.Commands
{
    public class MoveCommand : ICommand
    {
        public MoveCommand()
        {

        }

        public void Execute()
        {
            Console.Write("Car move!");
        }
    }
}
