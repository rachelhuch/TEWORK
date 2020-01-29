using System;
using System.Collections.Generic;
using System.Text;

namespace TollBoothCalculator.Classes
{
   public  interface IVehicle
    {
       double CalculateToll(int distance);
        //all it is is an implementation no return
    }
}
