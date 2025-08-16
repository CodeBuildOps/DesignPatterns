namespace DesignPatterns.Factory
{
    // Abstract Product
    interface IPizza
    {
        string Eat();
    }

    // Concrete Products
    class VegPizza : IPizza
    {
        public string Eat()
        {
            return "Eating veg pizza";
        }
    }
    class NonVegPizza : IPizza
    {
        public string Eat()
        {
            return "Eating Non-veg pizza";
        }
    }

    // Abstract Factory
    interface IChef
    {
        IPizza PreparePizza();
    }

    // Concrete Factories
    class VegChef : IChef
    {
        public IPizza PreparePizza()
        {
            return new VegPizza();
        }
    }
    class NonVegChef : IChef
    {
        public IPizza PreparePizza()
        {
            return new NonVegPizza();
        }
    }

    // Factory Producer
    class Waiter
    {
        private IChef _chef;
        public string GetPizza(string pref)
        {
            if (pref == "Veg")
                _chef = new VegChef();
            else
                _chef = new NonVegChef();

            return _chef.PreparePizza().Eat();
        }
    }
}