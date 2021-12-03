using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle  // Electric motorcycle
    {
        //BatteryKWh

        public int CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            CurrentChargePercentage = 89;

            // method definition omitted
        }



        public override void Turn(string direction)
        {
            Console.WriteLine(direction);
        }

        public override void Stop()
        {
            Console.WriteLine("The Vehicle gently rolls to a stop");
        }
        public override void Drive()
        {
            Console.WriteLine($"The new Zero {MainColor} Drive Past. woommmm");
            Stop();
            Turn("The vehicle carefuly turns right");
            Console.WriteLine();
        }
    }
}
