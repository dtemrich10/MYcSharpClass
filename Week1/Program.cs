using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Vehicle vehicle = new Vehicle();

            vehicle.Color = "Blue";

            Vehicle myVehicle = new Vehicle();

            myVehicle.Color = "red";
            myVehicle.OpenDoor();

            Car car = new Car();
            car.OpenDoor();
        }
    }
}