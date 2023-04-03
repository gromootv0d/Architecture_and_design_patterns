using CoolCar.Models;

namespace CoolCar.Commands
{
    public class RotateCommand : ICommand
    {
        public RotateCommand()
        {

        }

        public void Execute()
        {
            Console.Write("Car rotate!");
        }
    }
}
