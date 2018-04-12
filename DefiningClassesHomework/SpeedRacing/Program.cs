using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int count = int.Parse(Console.ReadLine());
        List <Car> cars = new List<Car>();
        List<Car> newCars = new List<Car>();
        for (int i  = 0; i < count; i++)
        {
            string[] tokens = Console.ReadLine().Split();
            string model = tokens[0];
            double fuelAmountToken = double.Parse(tokens[1]);
            double fuelConsuptionForOneKm = double.Parse(tokens[2]);
            Car car = new Car(model, fuelAmountToken, fuelConsuptionForOneKm);
            cars.Add(car);
        }

        string command;
        while ((command=Console.ReadLine()) != "End")
        {
            string[] commandTokens = command.Split(" ");
            string modelToDrive = commandTokens[1];
            double distanceToDrive = double.Parse(commandTokens[2]);
            cars.Where(c => c.model == modelToDrive).ToList().ForEach(c => c.Drive(distanceToDrive));
     
        }

        foreach (Car car in cars)
        {
            Console.WriteLine($"{car.model} {car.fuelAmount:f2} {car.distanceTraveled}");
        }
    }
}

