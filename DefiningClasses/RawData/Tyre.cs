using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tyre
    {
        public double TyrePressure { get; set; }
        public double TyreAge { get; set; }
        public Tyre(double tyrePressure,double tyreAge)
        {
            this.TyrePressure = tyrePressure;
            this.TyreAge = tyreAge;
        }
    }
}
