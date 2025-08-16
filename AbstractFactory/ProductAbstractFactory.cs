using DesignPatterns.Factory;

namespace DesignPatterns.AbstractFactory
{
    //  Factory manages object creation logic in one place,
    //  So the client code depends only on an interface/abstract class, not on concrete implementations.

    // Abstract Factory
    interface I_productFactory
    {
        IPizza PreparePizza();
        IBurger PrepareBurger();
    }

    // Concrete Factories
    class VegFactory : I_productFactory
    {
        public IPizza PreparePizza()
        {
            return new VegPizza();
        }
        public IBurger PrepareBurger()
        {
            return new VegBurger();
        }
    }

    class NonVegFactory : I_productFactory
    {
        public IPizza PreparePizza()
        {
            return new NonVegPizza();
        }
        public IBurger PrepareBurger()
        {
            return new NonVegBurger();
        }
    }

    // Factory Producer
    internal class Service
    {
        private I_productFactory _product;
        public Service(string type)
        {
            switch (type.ToUpper())
            {
                case "veg":
                    _product = new VegFactory();
                    break;
                default:
                    _product = new NonVegFactory();
                    break;
            }
        }

        public string GetPrizza()
        {
            return _product.PreparePizza().Eat();
        }
        public string GetBurger()
        {
            return _product.PrepareBurger().Eat();
        }
    }
}