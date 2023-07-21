using CoolCar.Models;

namespace CoolCar.Commands
{
    public class MoveForwardCommand : ICommand
    {
        private readonly CarTank _tank;
        private readonly int _distance;

        public MoveForwardCommand(CarTank tank, int distance)
        {
            _tank = tank ?? throw new ArgumentNullException(nameof(tank));
            _distance = distance;
        }

        public void Execute()
        {
            // Рассчитываем расход топлива на пройденное расстояние
            var fuelConsumption = _tank.FuelConsumption * _distance;

            if (_tank.Fuel >= fuelConsumption)
            {
                // Двигаемся на заданное расстояние
                _tank.Fuel -= fuelConsumption;
                _tank.DistanceTraveled += _distance;

                // Устанавливаем скорость машины в зависимости от расхода топлива и расстояния
                _tank.CurrentSpeed = _distance / _tank.FuelConsumption;
            }
            else
            {
                // Если топлива недостаточно, останавливаем машину
                _tank.CurrentSpeed = 0;
                throw new InvalidOperationException("Недостаточно топлива для движения на заданное расстояние");
            }
        }
    }

}
