using CoolCar.Models;
using CoolCar.Commands;
using Xunit;
using CoolCar.Exceptions;

namespace CoolCar.Tests
{
    public class BurnFuelCommandTest
    {
        [Fact]
        public void BurnFuelCommand_ShouldThrowArgumentNullException_WhenGetNull()
        {

            Assert.Throws<ArgumentNullException>(() => new BurnFuelCommand(null)); 
        }

        [Fact]
        public void BurnFuelCommand_WithValidTank_ShouldDecreaseFuelLevel()
        {
            // Arrange
            CarTank tank = new CarTank() { Fuel = 100, FuelConsumption = 10 };
            ICommand burnFuelCommand = new BurnFuelCommand(tank);

            // Act
            burnFuelCommand.Execute();

            // Assert
            Assert.Equal(100 - 10, tank.Fuel);
        }
    }
}
