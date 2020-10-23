using System;
using System.Linq;
using System.Collections.Generic;

namespace Algorithms
{
    public class InsertionSort<T> where T : IComparable
    {
        public static T[] Sort(T[] input)
        {
            for (int j = 1; j < input.Count(); j++)
            {
                T key = input[j];
                Console.WriteLine(key);
                int i = j - 1;

                // check if input[i] > key
                while (i >= 0 && input[i].CompareTo(key) > 0)
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