using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class StringExercises
    {
        /*
         Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or
         whatever is there if the string is less than length 3. Return n copies of the front;
         FrontTimes("Chocolate", 2) → "ChoCho"
         FrontTimes("Chocolate", 3) → "ChoChoCho"
         FrontTimes("Abc", 3) → "AbcAbcAbc"
         */
        public string FrontTimes(string str, int n)
        {
            //assign an empty string
            string empty = "";
            //if the string is less than 3, return string. Else you want the first three letters 
            string first = str.Length < 3 ? str : str.Substring(0, 3);
            //iterate through a for loop- with it repeating up to n times
            for (int i = 0; i < n; i++)
            {
                //empty now equals empty + first   (addition assignment operator +=)
                empty += first;
            }
            //return the string first which now has all of the iterations in it
            return empty;



        }

    }
}
