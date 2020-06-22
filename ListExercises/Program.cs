using System;
using System.Collections.Generic;
//using System.Text;
using System.Linq;

namespace ListExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = Sum.SumEvenNumbers(numbers);
            Console.WriteLine(sum);

            string text = "I would not, could not, in a box. " +
                "I would not, could not with a fox. " +
                "I will not eat them in a house. " +
                "I will not eat them with a mouse.";

            // Convert string into an array of words
            string[] wordsArray = text.Split(" ");

            // Convert array into list
            List<string> words = wordsArray.ToList();

            Print.PrintWords(words);
        }
    }
}
