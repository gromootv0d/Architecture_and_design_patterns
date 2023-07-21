using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolCar.Models
{
    public class CarTank
    {
        public int Fuel { get; set; }
        public int FuelConsumption { get; set; }

        public int DistanceTraveled {get; set;}
        public int CurrentSpeed { get; set;}
    }
}
