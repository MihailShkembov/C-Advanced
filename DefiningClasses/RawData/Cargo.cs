﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Cargo
    {
        public double CargoWeight { get; set; }
        public string CargoType { get; set; }
        public Cargo(double cargoWeith,string cargoType)
        {
            this.CargoWeight = cargoWeith;
            this.CargoType = cargoType;
        }
    }
}
