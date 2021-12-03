using System;
namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public double FuelCapacity { get; set; }


        public double BatteryKWh { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vrooomm");
        }

        public virtual void Turn(string direction)
        {

            Console.WriteLine(direction);
        }

        public virtual void Stop()
        {
            Console.WriteLine("");
        }
    }



}
