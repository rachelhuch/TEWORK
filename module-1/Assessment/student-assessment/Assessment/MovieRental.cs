using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    class MovieRental
    {
        public class Movie
        {

            public string title { get; set; }
            public string format { get; set; }

            public bool premiumMovie { get; set; }

            public Movie(string aTitle, string aFormat, bool isPremium)
            {
                title = aTitle;
                format = aFormat;
                premiumMovie = isPremium;

            }

            public decimal price;
          ////  public decimal Price() 
          //  {
          //          if (!premiumMovie)
          //          {
          //              if (format == "VHS")
          //              {
          //                  price = .99M;
          //                  Console.WriteLine(price);


          //              }
          //              else if (format == "DVD")
          //              {
          //                  price = 1.99M;
          //                  Console.WriteLine(price);

          //              }
          //              else if (format == "BluRay")
          //              {
          //                  price = 2.99M;
          //                  Console.WriteLine(price);

          //              }


          //              else if (premiumMovie)
          //              {
          //                  if (format == "VHS")
          //                  {
          //                      price = 1.99M;
          //                      Console.WriteLine(price);
          //                  }
          //                  else if (format == "DVD")
          //                  {
          //                      price = 2.99M;
          //                      Console.WriteLine(price);
          //                  }
          //                  else if (format == "BluRay")
          //                  {
          //                      price = 3.99M;
          //                      Console.WriteLine(price);
          //                  }
          //                  else
          //                  {
          //                      price = 0.00M;
          //                      Console.WriteLine(price);
          //                  }
          //              }
          //          }
          //      }
          //  }

            public int daysLate;

            public decimal GetLateFee()
            {
                if (daysLate ==0)
                {
                    return 0.00M;
                }

                else if (daysLate ==1)
                {
                    return 1.99M;
                }
                else if (daysLate ==2)
                {
                    return 3.99M;
                }
                //directions say if equal to 2 or more but the one above is eqaul to 2.
                else 
                {
                    return 19.99M;
                }
            }
            }

    }
}
