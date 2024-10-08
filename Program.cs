using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CarZo.Vehicle;

namespace CarZo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Uppgift 2
            // Skapa några fordon
            Car car = new Car("Volvo", "V60", 5);
            Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Street 750", false);
            Truck truck = new Truck("Scania", "R500", 3);

            // Skriv ut alla fordon
            Console.WriteLine("Alla fordon:");
            Console.WriteLine(car);
            Console.WriteLine(motorcycle);
            Console.WriteLine(truck);

            // Filtrera och skriv ut bara bilar
            Console.WriteLine("\nBara bilar:");
            if (car is Car)
            {
                Console.WriteLine(car);
            }

            // Kör alla fordon
            Console.WriteLine("\nKör alla fordon:");
            car.Drive();
            motorcycle.Drive();
            truck.Drive();

            */

            // Uppgift 3 

            List<Vehicle> vehicles = new List<Vehicle>();

            // Lägg till några fordon
            vehicles.Add(new Car("Volvo", "V60", 5));
            vehicles.Add(new Motorcycle("Harley-Davidson", "Street 750", false));
            vehicles.Add(new Truck("Scania", "R500", 3));
            vehicles.Add(new Car("Toyota", "Corolla", 4));

            // Skriv ut alla fordon
            Console.WriteLine("Alla fordon:");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }

            // Filtrera och skriv ut bara bilar
            Console.WriteLine("\nBara bilar:");
            var cars = FilterVehicles<Car>(vehicles);
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            // Sälj ett fordon
            var vehicleToSell = vehicles.Find(v => v.Brand == "Toyota");
            if (vehicleToSell != null)
            {
                SellVehicle(vehicles, vehicleToSell);
            }

            // Skriv ut uppdaterad lista
            Console.WriteLine("\nUppdaterad lista efter försäljning:");
            foreach (var vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        static List<T> FilterVehicles<T>(List<Vehicle> vehicles) where T : Vehicle
        {
            return vehicles.OfType<T>().ToList();
        }

        static void SellVehicle(List<Vehicle> vehicles, Vehicle vehicle)
        {
            Console.WriteLine($"\nSäljer fordon: {vehicle}");
            vehicles.Remove(vehicle);
        }

    }
}
