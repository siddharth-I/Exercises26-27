using System;

namespace Exercises26_27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 26
            string answerOne;
            do
            {
                int countOne = 0;
                Console.WriteLine("Enter some text: ");
                string jibberishOne = Console.ReadLine();
                string lowerJibberishOne = jibberishOne.ToLower();
                foreach (char c in lowerJibberishOne)
                {
                    if ("aeiou".Contains(c))
                    {
                        countOne++;
                    }
                }
                Console.WriteLine($"There were {countOne} vowels.");
                Console.WriteLine("Would you like to continue? Y/N");
                answerOne = Console.ReadLine();
            } while (answerOne == "Y");
            Console.WriteLine("Goodbye!");

            //Exercise 27
            string answerTwo;
            do
            {
                int countTwo = 0;
                Console.WriteLine("Enter some text: ");
                string jibberishTwo = Console.ReadLine();
                string lowerJibberishTwo = jibberishTwo.ToLower();
                foreach (char c in lowerJibberishTwo)
                {
                    if ("bcdfghjklmnpqrstvwxyz".Contains(c))
                    {
                        countTwo++;
                    }
                }
                Console.WriteLine($"There were {countTwo} consonants.");
                Console.WriteLine("Would you like to continue? Y/N");
                answerTwo = Console.ReadLine();
            } while (answerTwo == "Y");
            Console.WriteLine("Goodbye!");

        }
    }
}
