using System;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Ask the user for the search string
            Console.WriteLine("Please enter a search string.");
            string input = Console.ReadLine();
            //2. Ask the user for the file path
            Console.WriteLine("Please enter the file path.");
            string stream = Console.ReadLine();
            using (StreamReader str = new StreamReader(stream)
            {

            }
            //3. Open the file
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number
        }
    }
}
