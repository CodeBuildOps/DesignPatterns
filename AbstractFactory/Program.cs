using DesignPatterns.Factory;
using System;

namespace DesignPatterns.AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Client does not know concrete implementations, only the Abstract Factory
            Service service = new Service("veg");
            Console.WriteLine(service.GetPrizza());
            Console.WriteLine(service.GetBurger());
        }
    }
}