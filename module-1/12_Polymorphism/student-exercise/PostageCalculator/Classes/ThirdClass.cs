using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator.Classes
{
   public  class ThirdClass :IDeliveryDriver
    {


        public ThirdClass(int distance, double weight)
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
                    double rate = 0.0020 * distance;
                    return rate;

                }
                else if (weight <= 8)
                {
                    double rate = 0.0022 * distance;
                    return rate;

                }
                else if (weight <= 15)
                {
                    double rate = 0.0024 * distance;
                    return rate;
                }
                else if (weight <= 48)
                {
                    double rate = 0.0150 * distance;
                    return rate;
                }
                else if (weight <= 128)
                {
                    double rate = 0.0160 * distance;
                    return rate;
                }
                else
                {
                    double rate = 0.017 * distance;
                    return rate;
                }

            }
        }
    }
}
}
