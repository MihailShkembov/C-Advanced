using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RawData
{
   public class Program
    {
        static void Main(string[] args)
        {
            //"{model} {engineSpeed} {enginePower} {cargoWeight}
            //{cargoType} {tire1Pressure} {tire1Age} {tire2Pressure}
            //{tire2Age} {tire3Pressure} {tire3Age} {tire4Pressure} {tire4Age}"
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] cmd = Console.ReadLine().Split().ToArray();
                string model = cmd[0];
                double engineSpeed = double.Parse(cmd[1]);
                double enginePower = double.Parse(cmd[2]);
                var currEngine = new Engine(engineSpeed, enginePower);
                double cargoWeight = double.Parse(cmd[3]);
                string cargoType = cmd[4];
                var currCargo = new Cargo(cargoWeight, cargoType);
                var allCurTyres = cmd.Skip(5).ToArray();
                List<Tyre> allTyres = new List<Tyre>();
                for (int k = 0; k < allCurTyres.Length; k+=2)
                {
                    double tyrePressure = double.Parse(allCurTyres[k]);
                    double tyreAge = double.Parse(allCurTyres[k+1]);
                    var currTyre = new Tyre(tyrePressure, tyreAge);
                    allTyres.Add(currTyre);
                }
                var currCar = new Car(model, currEngine, currCargo, allTyres);
                cars.Add(currCar);
            }
        
            switch (Console.ReadLine())
            {
                case "fragile":
                    foreach (Car car in cars)
                    {
                        if (car.Cargo.CargoType== "fragile"&&car.Tyres.Any(x=>x.TyrePressure<1))
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                    ;break;
                case "flamable":
                    foreach (Car car in cars)
                    {
                        if (car.Cargo.CargoType == "flamable" && car.Engine.EngingePower>250)
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
