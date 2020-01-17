using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 3 int values, a b c, return their sum. However, if one of the values is the same as another
         of the values, it does not count towards the sum.
         LoneSum(1, 2, 3) → 6
         LoneSum(3, 2, 3) → 2
         LoneSum(3, 3, 3) → 0
         */
        public int LoneSum(int a, int b, int c)
        {
            bool aEqualsB = (a == b);
            bool bEqualsC = (b == c);
            bool cEqualsa = (c == a);

            if (aEqualsB && cEqualsa)
            {
              
                return 0;
                    }
                else if (aEqualsB)
                    {
                return c;
                        
                    }
            if (bEqualsC && cEqualsa)
            {
                return 0;
            }
            else if (bEqualsC)
            {
                return a;
            }
             
              
                
            

            if (bEqualsC)
            {
                if (cEqualsa)
                {
                    return 0;
                }
                else
                {
                    return a;
                }
            }

            if (cEqualsa)
            {
                return b;
            }

            return (a + b + c);
             

        }
   
       
    }
}
