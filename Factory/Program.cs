namespace DesignPatterns.Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Normally without any pattern, we might do something like the below one,
            // The client code directly depends on concrete classes(Car, Bike, Truck)

            //Car car = new Car();
            //car.Drive();

            //Bike bike = new Bike();
            //bike.Drive();

            //Truck truck = new Truck();
            //truck.Drive();


            // Client uses Factory instead of new, and only knows about IVehicle, not about concrete classes

            IVehicle car = VehicleFactory.GetVehicle("car");
            car.Drive();

            IVehicle bike = VehicleFactory.GetVehicle("bike");
            bike.Drive();

            IVehicle truck = VehicleFactory.GetVehicle("truck");
            truck.Drive();
        }
    }
}