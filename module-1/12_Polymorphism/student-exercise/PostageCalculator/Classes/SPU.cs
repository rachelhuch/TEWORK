﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PostageCalculator
{
    public class SPU : IDeliveryDriver
    {
        public SPU(int distance, double weight)

        {
            this.Distance = distance;
            this.Weight = weight;
        }

        public int Distance { get; }
        public double Weight { get; set; }

        public string Type { get; }
        public double CalculateRate(int distance, double weight)
        {
            
            
                double rate = (weight * .0050) * distance;
                return rate;

            }
            

        
    }
}
