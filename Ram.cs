using System;

namespace Garage
{
    public class Ram : Vehicle, IGas   // Gas powered truck
    {

        //FuelCapacity

        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            CurrentTankPercentage = 14.4;
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The Ram {MainColor} Drive Past. Rummm Rummmm");
        }
    }
}
