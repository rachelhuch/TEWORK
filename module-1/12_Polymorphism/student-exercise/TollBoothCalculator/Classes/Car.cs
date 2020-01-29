using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
   public  class Car : IVehicle
    {
        public bool HasTrailer { get; }

        public double CalculateToll(int distance)
            {
                if (HasTrailer)
            {
                double toll = (distance*.020) + 1.00;
                return toll;
            }
            else
            {
                double toll = distance * .020;
                return toll;
            }
                
        }
        public Car (bool hasTrailer)
        {
            HasTrailer = hasTrailer;
        }
        }
    }


