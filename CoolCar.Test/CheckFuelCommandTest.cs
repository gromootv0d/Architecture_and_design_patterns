using CoolCar.Commands;
using CoolCar.Exceptions;
using CoolCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CoolCar.Tests
{
    public class CheckFuelCommandTest
    {
        [Fact]
        public void CheckFuelCommand_ShouldThrowArgumentNullException_WhenGetNull()
        {
            Assert.Throws<ArgumentNullException>(() => new CheckFuelCommand(null));
        }
        [Fact]
        public void CheckFuelCommand_ShouldThrowCommandException_WhenGetNotEnoughFuel()
        {
            CarTank tank = new CarTank() { Fuel = 100, FuelConsumption = 101 };
            ICommand CheckFuelCommand = new CheckFuelCommand(tank);

            Assert.Throws<CommandException>(() => CheckFuelCommand.Execute());
        }
    }
}
