﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
      Given 2 positive int values, return the larger value that is in the range 10..20 inclusive,
      or return 0 if neither is in that range.
      Max1020(11, 19) → 19
      Max1020(19, 11) → 19
      Max1020(11, 9) → 11
      */
      

        public int Max1020(int a, int b)
        {
       if (a>=10 && a<=20)//if a is in range
            {
                if (b>=10 && b <=20)
                {
                    return Math.Max(a, b);
                }
                return a;
            }
        else //a is not in range 
            {
                if (b >= 10 && b <= 20)
                {
                    return b;
                }
            }
         
      
            {
                return 0;
            }
        }

    }
}