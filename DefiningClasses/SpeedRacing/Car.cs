using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
        //"{model} {fuelAmount} {fuelConsumptionFor1km}"
        //private string model;
        //private double fuelAmount;
        //private double fuelPerKm;
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelPerKm { get; set; }
        public double DistanceTravelled { get; set; }
        public Car(string model, double fuelAmount,double fuelPerKm)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelPerKm = fuelPerKm;
            this.DistanceTravelled = 0;
        }
        public void Drive(double distanceTravelled)
        {
            double fuelNeeded = distanceTravelled * this.FuelPerKm;
            if (this.FuelAmount>=fuelNeeded)
            {
                this.DistanceTravelled += distanceTravelled;
                this.FuelAmount -= fuelNeeded;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:F2} {this.DistanceTravelled}";
        }
    }
}
