using System;

namespace Garage
{
    public class Cessna : Vehicle, IGas // Propellor light aircraft
    {
        //FuelCapacity


        public double CurrentTankPercentage { get; set; }
        public void RefuelTank()
        {
            // method definition omitted
            CurrentTankPercentage = 16.4;
        }

        public override void Drive()
        {
            Console.WriteLine($"The New Cesna {MainColor} Drive Past. Zooommmmmm");
        }
    }
}
