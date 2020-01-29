using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator
{
   public class FexEd :IDeliveryDriver
    {
        public FexEd(int distance, double weight)

        {
            this.Distance = distance;
            this.Weight = weight;
        }

        public int Distance { get; }
        public double Weight { get; }

        public double CalculateRate(int distance, double weight)
        { 
            if (distance > 500 && weight > 48)
                {
                double rate = 20 + 5 +3;
                return rate;

            }
           else if (weight > 48 && distance <500)
            {
                double rate = 20 + 3;
                return rate;
            }
           else if (weight <48 && distance >500)
            {
                double rate = 20 + 5;
                return rate;
            }
            else
            {
                double rate = 20;
                return rate;
            }
        }

      
    }
}
