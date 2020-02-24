using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class MovieRental
    {

        public string title { get; set; }
        public string format { get; set; }
        public bool premiumMovie { get; set; }

        public MovieRental(string aTitle, string aFormat, bool isPremium)
        {
            title = aTitle;
            format = aFormat;
            premiumMovie = isPremium;

        }

        public decimal price
        {
            get { return price; }
            set
            {


                if (format == "VHS")
                {
                    price = .99M;



                }
                else if (format == "DVD")
                {
                    price = 1.99M;


                }
                else if (format == "BluRay")
                {
                    price = 2.99M;

                }
                else
                {
                    Console.WriteLine("Price not found");
                }

                if (premiumMovie)
                {
                    price += 1.00M;
                }


            }

        }

        public int daysLate;

        public decimal GetLateFee()
        {
            if (daysLate == 0)
            {
                return 0.00M;
            }

            else if (daysLate == 1)
            {
                return 1.99M;
            }
            else if (daysLate == 2)
            {
                return 3.99M;
            }
            //directions say if equal to 2 or more but the one above is eqaul to 2.
            else
            {
                return 19.99M;
            }
        }


        public override string ToString()
        {
            return ($"Movie -{title}- {format}- {price}");//quotation marks because it's returning a string
        }
    }

}
//file reading or writing put in a try block and have a catch
//try
{
using (StreamReader sr = new StreamReader(@"C:\Users\Student\git\rachelhuch-c\module-1\Assessment\student-assessment\Assessment\Data\MovieInput.csv"));
decimal movierental;
List<Movie> movies = new List<Movie>();

while(!sr.endofstream)
    {
    string line = sr.ReadLine();
string[] parts = line.Split("|");
Movie M = new new Movie()
    m.Title = parts[0];
    m.Rating=parts[1];
    etc
    movierental +=m.Rental;
    Movies.Add(m);
}
    Console.WrriteLine()
foreach (Movie M in movies)
    {
    Console.WriteLine();
    }



//catch(IOException ex)
//Console.WriteLine(ex.Message);
    
    //close streamreader

