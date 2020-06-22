using System;

namespace StringExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "I would not, could not, in a box. " +
                "I would not, could not with a fox. " +
                "I will not eat them in a house. " +
                "I will not eat them with a mouse.";

            string[] words = text.Split(" ");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            string[] sentences = text.Split(".");
            foreach (string sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}
