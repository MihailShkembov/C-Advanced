using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
  public  class Car
    {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public List<Tyre> Tyres { get; set; }
        public Car(string model,Engine engine,Cargo cargo, List<Tyre> tyres)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tyres = tyres;
        }
    }
}
