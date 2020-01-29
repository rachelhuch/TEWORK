using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SPU : IDeliveryDriver
    {
        public SPU(int distance, double weight, string type)

        {
            this.Distance = distance;
            this.Weight = weight;
            this.Type = type;
        }

        public int Distance { get; }
        public double Weight { get; set; }

        public string Type { get; }
        public double CalculateRate(int distance, double weight)
        {
            if (Type == "4-Day Ground")
            {
                double rate = (weight * .0050) * distance;
                return rate;

            }
            else if (Type == "2-Day Business")
            {
                double rate = (weight * 0.050) * distance;
                return rate;
            }
            else if (Type == "Next Day")
            {
                double rate = (weight * 0.075) * distance;
                return rate;
            }
            else
            {
                return 0;
            }
        }
    }
}
