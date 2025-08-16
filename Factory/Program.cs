namespace DesignPatterns.Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Normally without any pattern, we might do something like the below one,
            // The client code directly depends on concrete classes(VegPizza, NonVegPizza)

            // Client uses Factory instead of new, and only knows about IPizza, not about concrete classes

            IPizza pizza = ProductFactory.GetPizza("Veg");
            pizza.Eat();

            pizza = ProductFactory.GetPizza("Non");
            pizza.Eat();
        }
    }
}