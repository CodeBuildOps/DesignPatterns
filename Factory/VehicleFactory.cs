namespace DesignPatterns.Factory
{
    //  Factory manages object creation logic in one place,
    //  So the client code depends only on an interface/abstract class, not on concrete implementations.
    internal class VehicleFactory
    {
        public static IVehicle GetVehicle(string type)
        {
            IVehicle vehicle;

            switch(type.ToUpper())
            {
                case "CAR":
                    vehicle = new Car();
                    break;
                case "BIKE":
                    vehicle = new Bike();
                    break;
                default:
                    vehicle = new Truck();
                    break;
            }
            return vehicle;
        }
    }
}