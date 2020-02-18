using System;
using static Assessment.MovieRental;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Movie movie = new Movie("Dog", "VHS", false);
            Console.WriteLine($"{movie.title},{movie.format}");
            

        }
    }
}
