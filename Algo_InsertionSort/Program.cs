using System;
using System.Linq;

namespace Algo_InsertionSort
{
	class Program
	{
		static void Main(string[] args)
		{
			Func<int[], string> ArrayToString = x => string.Join(", ", x);
			int[] input = { 5, 2, 4, 6, 1, 3 };
			Console.WriteLine(ArrayToString(input));
			Console.WriteLine();

			for (int j = 1; j < input.Count(); j++)
			{
				int key = input[j];
				Console.WriteLine(key);
				int i = j - 1;
				while (i >= 0 && input[i] > key)
				{
					input[i + 1] = input[i];
					i = i - 1;
					Console.WriteLine(ArrayToString(input));
				}

				input[i + 1] = key;
				Console.WriteLine(ArrayToString(input));
			}
		}
	}
}
