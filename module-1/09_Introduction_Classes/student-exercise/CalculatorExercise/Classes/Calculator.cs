using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /// <summary>
    /// Represents a "simple" calculator
    /// </summary>
    public class Calculator
    {

        public Calculator()
        {
        }
            public int Result { get; private set; }
        public int Add(int addend)
        {
            Result = Result + addend;
            return Result;
        }
        public int Multiply(int multiplier)
        {
            Result = multiplier * Result;
            return Result;
        }
        public int Power(int exponent)
        {
            //math abs gives absolute value of something, make sure we don't have a negative 
            exponent = Math.Abs(exponent);

            Result = Math.Abs(Result);

            Result = (int)Math.Pow((double)Result, (double)exponent);
            return Result;
        
        }
        public void Reset()
        {
            Result = 0;
            
        }

        public int Subtract(int subtrahend)
        {
            Result = Result - subtrahend;
            return Result;
        }
        }

    }

