using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
    public class SecondClass :IDeliveryDriver
    {
       
       
            public SecondClass(int distance, double weight)
            {
                this.Distance = distance;
                this.Weight = weight;
public int Distance { get; }
public double Weight { get; }

 
        public double CalculateRate(int distance, double weight)
        {

            if (weight <= 2)
            {
                double rate = 0.0035 * distance;
                return rate;

            }
            else if (weight <= 8)
            {
                double rate = 0.040 * distance;
                return rate;

            }
            else if (weight <= 15)
            {
                double rate = 0.0047 * distance;
                return rate;
            }
            else if (weight <= 48)
            {
                double rate = 0.00195 * distance;
                return rate;
            }
            else if (weight <= 128)
            {
                double rate = 0.045 * distance;
                return rate;
            }
            else
            {
                double rate = 0.05 * distance;
                return rate;
            }

        }
    }
}