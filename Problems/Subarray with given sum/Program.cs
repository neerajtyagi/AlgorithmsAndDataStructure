using System;
using System.Collections.Generic;

namespace Subarray_With_Given_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SubArray> data = new List<SubArray>();

            string inputLenght = Console.ReadLine();
            int length = int.Parse(inputLenght);
            for (int i = 0; i < length; i++)
            {
                string inputRange = Console.ReadLine();
                string inputData = Console.ReadLine();
                data.Add(new SubArray(inputRange, inputData));
            }

            foreach (var item in data)
            {
                item.Solve();
            }
        }
    }
}
