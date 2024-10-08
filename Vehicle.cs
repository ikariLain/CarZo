using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarZo
{
    public interface IDriveable
    {
        void Drive();
        
    }
    abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Vehicle(string Brand, string Model)
        {
          this.Brand = Brand;
          this.Model = Model;

        }

        public override string ToString()
        {
            return $"{Brand} {Model}";
        }

        public class Car : Vehicle, IDriveable 
        {
            public int NumberOfPassengers { get; set; }

            public Car(string Brand, string Model, int NumberOfPassengers) :base (Brand, Model)
            {
                this.NumberOfPassengers = NumberOfPassengers;
            }

            public void Drive()
            {
                Console.WriteLine($"Driving the car: {Brand} {Model} with {NumberOfPassengers} passengers");
            }

            public override string ToString()
            {
                return $"{Brand} {Model}, {NumberOfPassengers} passengers";
            }

        }
        public class Motorcycle : Vehicle, IDriveable
        {
            public bool HasSidecar { get; set; }

            public Motorcycle(string Brand, string Model, bool hasSidecar) : base (Brand, Model)
            {
                this.HasSidecar= hasSidecar;
            }

            public void Drive ()
            {
                Console.WriteLine($"Riding the motorcycle: {Brand} {Model} with sidecar: {HasSidecar}");
            }

            public override string ToString()
            {
                return $"{Brand} {Model}, Sidecar: {(HasSidecar ? "Yes" : "No")}";
            }


        }
        public class Truck : Vehicle, IDriveable
        {
            public int NumberOfAxles { get; set; }

            public Truck(string Brand, string Model, int NumberOfAxles) : base (Brand, Model)
            {
               this .NumberOfAxles = NumberOfAxles;
            }
            
            public void Drive()
            {
                Console.WriteLine($"Driving the truck: {Brand} {Model} with {NumberOfAxles} axles");
            }
            public override string ToString()
            {
                return $"{Brand} {Model}, {NumberOfAxles} axles";
            }
        }

    }
}
