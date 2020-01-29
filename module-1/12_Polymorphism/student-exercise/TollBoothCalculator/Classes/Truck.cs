using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
    public class Truck : IVehicle
    {
        public int NumberOfAxels { get; }

        public Truck(int numberOfAxels)
        {
            NumberOfAxels = numberOfAxels;
        }
        public double CalculateToll(int distance)
        {
            if (NumberOfAxels == 4)
            {
                double toll = (distance * 0.040);
                return toll;
            }
            else if (NumberOfAxels == 6)
            {
                double toll = distance * 0.045;
                return toll;
            }
            else if (NumberOfAxels >= 8)
            {
                double toll = distance * 0.048;
                return toll;
            }
            else
            {
                double toll = 0.20 * distance;
                return toll;
            }
        }
    }
}
