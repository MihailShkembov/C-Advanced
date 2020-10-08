using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
      
        public double EngineSpeed { get; set; }
        public double EngingePower { get; set; }
        public Engine(double engineSpeed,double engingePower)
        {
            this.EngineSpeed = engineSpeed;
            this.EngingePower = engingePower;
        }
    }
}
