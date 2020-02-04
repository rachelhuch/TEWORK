using System;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            //1. Ask the user for the search string
            Console.WriteLine("Please enter a search string.");
            string input = Console.ReadLine();

            Console.WriteLine("Would you like this search to be case sensitive? y or n?");
            string caseSensitiveInput = Console.ReadLine();
         

            //2. Ask the user for the file path

            //alices_adventures_in_wonderland.txt
            Console.WriteLine("Please enter the file path.");
            string stream = Console.ReadLine();

            if (caseSensitiveInput.StartsWith('y'))
            {



                using (StreamReader str = new StreamReader(stream))
                {
                    while (!str.EndOfStream)
                    {
                        string line = str.ReadLine();
                        if (line.Contains(input))
                        {

                            Console.WriteLine(line);
                            Console.WriteLine(num);
                            num++;

                        }
                        else
                        {
                            num++;
                        }

                    }
                }
            }

            else
            {
                using (StreamReader str = new StreamReader(stream))
                {
                    while (!str.EndOfStream)
                    {
                        string line = str.ReadLine();
                        string lowerCaseLine = line.ToLower();
                        if (lowerCaseLine.Contains(input.ToLower()))
                        {

                            Console.WriteLine(line);
                            Console.WriteLine(num);
                            num++;

                        }
                        else
                        {
                            num++;
                        }

                    }
                }
            }
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number
        }
    }
}

