using CoolCar.Exceptions;
using CoolCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCar.Commands
{
    public class BurnFuelCommand : ICommand
    {
        public readonly CarTank _tank;
        public BurnFuelCommand(CarTank tank) =>
            _tank = tank ?? throw new ArgumentNullException(nameof(tank));
        public void Execute()
        {
            _tank.Fuel -= _tank.FuelConsumption;
        }
    }
}
