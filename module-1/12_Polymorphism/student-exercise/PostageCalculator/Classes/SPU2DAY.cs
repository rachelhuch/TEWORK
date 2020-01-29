using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    class SPU2DAY : IDeliveryDriver
    {
        public SPU2DAY(int distance, double weight)

        {
            this.Distance = distance;
            this.Weight = weight;
            
        }

        public int Distance { get; }
        public double Weight { get; set; }

        public string Type { get; }
        public double CalculateRate(int distance, double weight)
        {
            double rate = (weight * 0.050) * distance;
            return rate;


        }
    }
    }
            
            

        //basically do same as postal service
  