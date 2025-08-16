namespace DesignPatterns.Factory
{
    //  Factory manages object creation logic in one place,
    //  So the client code depends only on an interface/abstract class, not on concrete implementations.
    internal class ProductFactory
    {
        private static IPizza _pizza;
        public static IPizza GetPizza(string type)
        {
            switch(type.ToUpper())
            {
                case "VEG":
                    _pizza = new VegPizza();
                    break;
                default:
                    _pizza = new NonVegPizza();
                    break;
            }
            return _pizza;
        }
    }
}