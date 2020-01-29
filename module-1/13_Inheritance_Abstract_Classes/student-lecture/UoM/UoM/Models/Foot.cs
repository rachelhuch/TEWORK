using System;
using System.Collections.Generic;
using System.Text;

namespace UoM.Models
{
    class Foot : Length
    {
        public override double ConversionFactor => 12 * 2.54;

        //constructor

        public Foot(double amt) : base("foot", "feet", amt) { }
    }
}
