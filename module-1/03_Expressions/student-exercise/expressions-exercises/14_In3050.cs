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
         Given 2 int values, return true if they are both in the range 30..40 inclusive, or they are both
         in the range 40..50 inclusive.
         In3050(30, 31) → true
         In3050(30, 41) → false
         In3050(40, 50) → true
         */
        public bool In3050(int a, int b)
        {
            if (((a<=40)&&(a>=30)) && ((b<=40)&&(b>=30)))
            {
                return true;
            }
            else if (((a <= 50) && (a >= 40)) && ((b <= 50) && (b >= 40)))
            { 
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
