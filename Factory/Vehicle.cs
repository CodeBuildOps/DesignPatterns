using System;

namespace DesignPatterns.Factory
{
    // My Product
    interface IVehicle
    {
        void Drive();
    }
    internal class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving Car...");
        }
    }
    internal class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving Bike...");
        }
    }
    internal class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving Truck...");
        }
    }
}