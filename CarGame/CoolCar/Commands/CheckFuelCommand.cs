using CoolCar.Exceptions;
using CoolCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCar.Commands
{
    public class CheckFuelCommand : ICommand
    {
        public readonly CarTank _tank;

        public CheckFuelCommand(CarTank tank) =>
            _tank = tank ?? throw new ArgumentNullException(nameof(tank));

        public void Execute()
        {
            if (_tank.Fuel < _tank.FuelConsumption)
                throw new CommandException(this);
        }
    }
}
