using CoolCar.Commands;
using CoolCar.Models;
using Xunit;

namespace CoolCar.Tests
{
    public class MoveForwardCommandTest
    {
        [Fact]
        public void Execute_EnoughFuel_MovesCarAndUpdatesFuel()
        {
            // Arrange
            CarTank tank = new CarTank();
            tank.Fuel = 100;
            tank.FuelConsumption = 1;
            tank.CurrentSpeed = 0;

            int distanceToMove = 10;
            ICommand moveCommand = new MoveForwardCommand(tank, distanceToMove);

            // Act
            moveCommand.Execute();

            // Assert
            Assert.Equal(90, tank.Fuel);
            Assert.Equal(distanceToMove, tank.DistanceTraveled);
            Assert.NotEqual(0, tank.CurrentSpeed);
        }

        [Fact]
        public void Execute_NotEnoughFuel_ThrowsException()
        {
            // Arrange
            CarTank tank = new CarTank();
            tank.Fuel = 5; // Not enough fuel to move 10 units with consumption 0.1 per unit
            tank.FuelConsumption = 1;
            tank.CurrentSpeed = 0;

            int distanceToMove = 10;
            MoveForwardCommand moveCommand = new MoveForwardCommand(tank, distanceToMove);

            // Act
            //moveCommand.Execute();

            // Assert
            Assert.Throws<InvalidOperationException>(() => moveCommand.Execute());
        }
    }
}
