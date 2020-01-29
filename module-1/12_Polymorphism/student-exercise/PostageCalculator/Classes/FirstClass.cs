using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class FirstClass : IDeliveryDriver
    {
        public FirstClass (int distance, double weight)
        {
            this.Distance = distance;
            this.Weight = weight;


        }
        public int Distance { get; }
        public double Weight { get; }

        public double CalculateRate(int distance, double weight)
        {
            
            if (weight <= 2)
            {
                double rate = 0.035 * distance;
                return rate;

            }
            else if (weight <= 8)
            {
                double rate = 0.40 * distance;
                return rate;

            }
            else if (weight <=15)
            {
                double rate = 0.047 * distance;
                return rate;
            }
            else if (weight <=48)
            {
                double rate = 0.0195 * distance;
                return rate;
            }
            else if (weight <= 128)
            {
                double rate = 0.45 * distance;
                return rate;
            }
            else
            {
                double rate = 0.5 * distance;
                return rate;
            }
            
        }
    }
}
