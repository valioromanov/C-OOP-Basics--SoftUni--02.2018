using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    public string model;

    public double fuelAmount;

    public double fuelConsumption;

    public double distanceTraveled;
    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumption = fuelConsumption;
    }

    public void Drive(double distance) {

        var fuel = this.fuelConsumption * distance;

        if (fuel > this.fuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.fuelAmount -= fuel;
            this.distanceTraveled += distance;
        }
    }
}

