namespace DesignPatterns.AbstractFactory
{
    // Abstract Products
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

    // Abstract Factory
    interface IChef
    {
        IPizza PreparePizza();
        IBurger PrepareBurger();
    }

    // Concrete Factories
    class VegChef : IChef
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
    class NonVegChef : IChef
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
    class Waiter
    {
        private readonly IChef _chef;
        public Waiter(string pref)
        {
            if (pref == "Veg")
                _chef = new VegChef();
            else
                _chef = new NonVegChef();
        }
        public string GetPrizza()
        {
            return _chef.PreparePizza().Eat();
        }
        public string GetBurger()
        {
            return _chef.PrepareBurger().Eat();
        }
    }
}