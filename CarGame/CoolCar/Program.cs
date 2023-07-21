using CoolCar.Commands;
using CoolCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CoolCar
{
    public class Program
    {
        static void Main()
        {
            var carTank = new CarTank() { Fuel = 1000, FuelConsumption = 10, CurrentSpeed = 0, DistanceTraveled = 0 };
            var moveCommand = new MoveForwardCommand(carTank, 10);
            var checkFuelCommand = new CheckFuelCommand(carTank);
            var burnFuelCommand = new BurnFuelCommand(carTank);

            var commands = new ICommand[] { checkFuelCommand, moveCommand, burnFuelCommand };

            var macroCommand = new MacroCommand(commands);

            macroCommand.Execute();
        }
    }
}
