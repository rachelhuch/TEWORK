using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class KataFizzBuzz
    {
        public string fizzBuzz(int num)
        {
            if (num > 100 || num < 0)
            {
                return "";
            }

            
            else if ((num % 3 == 0 && num % 5 == 0) || ((num.ToString().Contains("3")) && (num.ToString().Contains("5"))))
            {
                return "fizzbuzz";
            }
            else if (num.ToString().Contains("5") || (num % 5 == 0))
            {
                return "buzz";
            }
            else if (num % 3 == 0 || (num.ToString().Contains("3")))
            {
                return "fizz";

            }
           
            
            else  
            {
                return num.ToString();
            }

        }
    }
}