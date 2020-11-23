using System;
using System.Linq;
using System.Collections.Generic;

namespace Algorithms
{
    public class InsertionSort
    {
        public static int[] Sort(int[] input)
        {
            for (int j = 1; j < input.Count(); j++)
            {
                int key = input[j];
                Console.WriteLine(key);
                int i = j - 1;

                // check if input[i] > key
                while (i >= 0 && input[i] > key)
                {
                    input[i + 1] = input[i];
                    i = i - 1;
                }

                input[i + 1] = key;
            }

            return input;
        }
    }
}