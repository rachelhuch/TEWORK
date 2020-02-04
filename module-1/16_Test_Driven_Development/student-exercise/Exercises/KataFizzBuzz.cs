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
            if (num % 3 == 0 && num % 5 == 0)
            {
                return "fizzbuzz";
            }
            else if (num % 3 == 0)
            {
                return "fizz";

            }
            else if (num % 5 == 0)
            {
                return "buzz";
            }
            else  
            {
                return num.ToString();
            }

        }
    }
}