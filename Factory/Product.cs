using System;

namespace DesignPatterns.Factory
{
    // My Product
    interface IPizza
    {
        void Eat();
    }
    internal class VegPizza : IPizza
    {
        public void Eat()
        {
            Console.WriteLine("Eating VegPizza...");
        }
    }
    internal class NonVegPizza : IPizza
    {
        public void Eat()
        {
            Console.WriteLine("Eating NonVegPizza...");
        }
    }
}