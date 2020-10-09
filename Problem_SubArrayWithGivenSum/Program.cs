using System;
using System.Collections.Generic;

namespace Problem_SubArrayWithGivenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SubArray> data = new List<SubArray>();

            Console.WriteLine("Input: ");
            Console.WriteLine("No of arrays: ");
            string inputLenght = Console.ReadLine();
            int length = int.Parse(inputLenght);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Input {i}: <lenght> <sum>");
                string inputRange = Console.ReadLine();
                Console.WriteLine("Input Array: <N1> <N2> <N3> .... <Nn>");
                string inputData = Console.ReadLine();
                data.Add(new SubArray(inputRange, inputData));
            }

            Console.WriteLine("Output: ");
            foreach (var item in data)
            {
                item.Solve();
            }
        }
    }
}
