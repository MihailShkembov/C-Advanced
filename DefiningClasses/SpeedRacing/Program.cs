using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split().ToArray();
                var car = new Car(info[0], double.Parse(info[1]), double.Parse(info[2]));
                cars.Add(car);
            }
            string[] command = Console.ReadLine().Split().ToArray();
            while (!command.Contains("End"))
            {
                string curModel = command[1];
                double curKm = double.Parse(command[2]);
                var car = cars.Find(x => x.Model == curModel);
                car.Drive(curKm);
                command = Console.ReadLine().Split().ToArray();
            }
            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
