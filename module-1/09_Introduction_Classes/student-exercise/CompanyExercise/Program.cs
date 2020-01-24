using System;

namespace CompanyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public class Person
        {
            public Person()
            {

            }

            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int Age { get; set; }

            public string GetFullName()
            {
                return ($"{FirstName} ' ' {LastName}");
            }
            public bool IsAdult()
            {
                if (Age >= 18)
                {
                    return true;
                }
                else return false;
            }

        }
    }
}