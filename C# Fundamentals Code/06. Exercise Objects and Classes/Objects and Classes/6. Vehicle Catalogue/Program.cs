using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6._Vehicle_Catalogue
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<Vehicle> catalog = new List<Vehicle>();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string type = cmdArgs[0].ToLower();
                string model = cmdArgs[1];
                string color = cmdArgs[2].ToLower();
                int hp = int.Parse(cmdArgs[3]);

                Vehicle currVehicle = new Vehicle(type, model, color, hp);
                catalog.Add(currVehicle);
                command = Console.ReadLine();
            }

            string secondCommand = Console.ReadLine();
            while (secondCommand != "Close the Catalogue")
            {
                string modelType = secondCommand;
                Vehicle printCar = catalog.First(x => x.Model == modelType);
                Console.WriteLine(printCar);

                secondCommand = Console.ReadLine();
            }
            List<Vehicle> onlyCars = catalog.Where(x => x.Type == "car").ToList();
            List<Vehicle> onlyTrucks = catalog.Where(x => x.Type == "truck").ToList();

            double totalCarsHp = onlyCars.Sum(x => x.HorsePower);
            double totalTrucksHp = onlyTrucks.Sum(x => x.HorsePower);

            double avgCarHp = 0.00;
            double avgTruckHp = 0.00;

            if (onlyCars.Count > 0)
            {
                avgCarHp = totalCarsHp / onlyCars.Count;
            }
            if (onlyTrucks.Count > 0)
            {
                avgTruckHp = totalTrucksHp / onlyTrucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {avgCarHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgTruckHp:f2}.");

        }

        class Vehicle
        {
            public Vehicle(string type, string model, string color, int horsePower)
            {
                Type = type;
                Model = model;
                Color = color;
                HorsePower = horsePower;
            }

            // control i tochka => direktno konstruktor

            public string Type { get; set; }
            public string Model { get; set; }

            public string Color { get; set; }
            public int HorsePower { get; set; }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"Type: {(Type == "car" ? "Car" : "Truck")}");
                sb.AppendLine($"Model: {Model}");
                sb.AppendLine($"Color: {Color}");
                sb.AppendLine($"Horsepower: {HorsePower}");

                return sb.ToString().TrimEnd();
            }
        }
    }
}
