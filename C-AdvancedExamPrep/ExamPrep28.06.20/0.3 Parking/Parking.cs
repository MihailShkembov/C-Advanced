using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Parking
{
   public class Parking
    {
        private List<Car> data;
        public string Type { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return data.Count; } }
        public Parking(string type,int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            this.data = new List<Car>();
        }
        public void Add(Car car)
        {
            if (this.data.Count<this.Capacity)
            {
                this.data.Add(car);
            }
        }
        public bool Remove(string manufacturer, string model)
        {
            if (this.data.Any(x=>x.Manufacturer==manufacturer&&x.Model==model))
            {
                var car = this.data.Find(x => x.Manufacturer == manufacturer && x.Model == model);
                this.data.Remove(car);
                return true;
            }
            return false;
        }
        public Car GetLatestCar()
        {
            if (this.data.Any())
            {

                var maxYear = this.data.Max(car => car.Year);
                var tempCar = this.data.Find(x => x.Year == maxYear);
                return tempCar;
            }
            return null;
        }
        public Car GetCar(string manufacturer, string model)
        {
            if (this.data.Any(x => x.Manufacturer == manufacturer && x.Model == model))
            {
                var car = this.data.Find(x => x.Manufacturer == manufacturer && x.Model == model);
                return car;
            }
            return null;
        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");
            foreach (var item in this.data)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
