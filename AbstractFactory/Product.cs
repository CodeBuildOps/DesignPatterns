using System;

namespace DesignPatterns.AbstractFactory
{
    // Abstract Products (2)
    interface IPizza
    {
        string Eat();
    }
    interface IBurger
    {
        string Eat();
    }

    // Concrete Products
    class VegPizza : IPizza
    {
        public string Eat()
        {
            return "Eating Veg Pizza";
        }
    }
    class NonVegPizza : IPizza
    {
        public string Eat()
        {
            return "Eating Non-Veg Pizza";
        }
    }
    class VegBurger : IBurger
    {
        public string Eat()
        {
            return "Eating Veg Burger";
        }
    }
    class NonVegBurger : IBurger
    {
        public string Eat()
        {
            return "Eating Non-Veg Burger";
        }
    }
}