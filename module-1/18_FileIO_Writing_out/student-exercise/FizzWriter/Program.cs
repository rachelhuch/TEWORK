using System;
using System.IO;
using System.Collections.Generic;

namespace FizzWriter
{
    public class Program
    {
        public static void Main()
        {
            List<string> fizzbuzz = new List<string>();
            //StreamWriter needs to write to FizzBuzz.txt
            //new file should be created each time the code is run
            //fizz buzz stuff
            //need some sort of loop to go through and print out the numbers to the .txt file




            for (int num = 1; num <= 300; num++)


            {
                string result;
                if (num % 3 == 0 && (num % 5 == 0))
                {
                    result = "fizzbuzz";



                }
                else if (num.ToString().Contains("3") || num % 3 == 0)
                {
                    result = "fizz";

                }
                else if (num.ToString().Contains("5") || num % 5 == 0)
                {
                    result = "buzz";

                }
                else
                {
                    result = num.ToString();

                }
                fizzbuzz.Add(result);

            }
            string path = (@"C:\Users\Student\git\rachelhuch-c\module-1\18_FileIO_Writing_out\student-exercise\fizzbuzz.txt");
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (string list in fizzbuzz)
                {
                    sw.WriteLine(list);
                }

            }
            Console.WriteLine("FizzBuzz.txt has been created");
        }
    }
}
