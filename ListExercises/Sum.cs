using System;
using System.Collections.Generic;

namespace ListExercises
{
    public class Sum
    {
        public static int SumEvenNumbers(List<int> list)
        {
            int sum = 0;

            foreach (int number in list)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }
            return sum;
        }
    }
}
