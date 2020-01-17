using System;

namespace CommandLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine($"Hello {name}. How old are you?");
            //string input = Console.ReadLine();
            //int age = int.Parse(input);

            //Console.WriteLine($"Wow {name}, {age}, that's really old!");

            //string sentence = "Now is the time for all good people to come to the aid of their country";
            //string[]words=  sentence.Split(" ");

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.Write(words[i]);
            //}
            //sentence = string.Join(" : ", words);
            //Console.WriteLine(sentence);
            GetNumbersFromUser();
        }
        static public void ProperNouner()
        {
            while(true)
            {
                string input;

                //Prompt the user for a sentence
                Console.Write("Enter a sentence:");
                input = Console.ReadLine();
                //Split into words using space character
                string[] words = input.Split(" ");
                //Loop through the words and for each word capitalize the first letter and lower the rest
                for (int i = 0; i < words.Length; i++)
                {
                    string word = words[i];
                    word = word.ToLower();
                    //uppercase the firstletter and concat the rest of the word
                   word= word[0].ToString().ToUpper() + word.Substring(1);
                    //Replace the word in the array
                    words[i] = word;
                }
                string sentence = string.Join(" ", words);

                // Join the updated array into a new sentence

                //Display the proper noun sentence to the user. 
                Console.WriteLine(sentence);

                Console.Write("Again? (y/n");
                input = Console.ReadLine(); 
                if (input.ToLower() != "y")
                {
                    break;
                }
            }
        }
        static public void GetNumbersFromUser()

        {
            while ( true )
            {
                Console.Clear();
                // Greet the user and ask for a comma-delimited list of integers
                Console.Write("Please enter a list of comma-delimited numbers. Please be careful!");
                string input = Console.ReadLine();

                // Split the string into individual "number-strings"- will get a string array that will have each number
                string[] numberStrings = input.Split(",");
                //Cannot do math on the strings so we have to Parse the number strings into integers

                // Place integers into an array
                int[] nums = new int[numberStrings.Length];

                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = int.Parse(numberStrings[i]);
                }

                //iterate the numbers in the array and get the sum
                int sum = 0;

                for (int i = 0; i < nums.Length; i++)

                {
                    sum += nums[i];

                }
                //display the count, sum, and average to user
                Console.WriteLine($"Here are your answers: \r\n Count: {nums.Length}\r\n  Sum: {sum} \r\n  Average:{(double)sum / nums.Length}");
                Console.Write("Do you want to do another?(y/n)");
                input = Console.ReadLine();
                if (input.ToLower() != "y")
                {
                    break;
                }


            }
        }
    }
}


