using System;
using System.Linq;

namespace Algo_MergeSort
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] input = { 5, 2, 4, 9, 7, 1, 3, 2, 6 };
			PrintArray(input);
			Console.WriteLine();

			MergeSort(input, 0, input.Count() - 1);
			PrintArray(input);
		}

		public static void PrintArray(int[] arr)
		{
			Console.WriteLine(string.Join(", ", arr));
		}

		public static void MergeSort(int[] arr, int startIndex, int endIndex)
		{
			if (startIndex < endIndex)
			{
				int midIndex = (startIndex + endIndex) / 2;
				MergeSort(arr, startIndex, midIndex);
				MergeSort(arr, midIndex + 1, endIndex);
				Merge(arr, startIndex, midIndex, endIndex);
			}
		}

		public static void Merge(int[] arr, int startIndex, int midIndex, int endIndex)
		{
			int leftArrayLength = midIndex - startIndex + 1;
			int rightArrayLength = endIndex - midIndex;

			int[] leftArray = new int[leftArrayLength];
			int[] rightArray = new int[rightArrayLength];

			// Copy left array into new Array
			for (int iLeftArray = 0; iLeftArray < leftArrayLength; iLeftArray++)
			{
				leftArray[iLeftArray] = arr[startIndex + iLeftArray];
			}

			// Copy right array into new Array
			for (int iRightArray = 0; iRightArray < rightArrayLength; iRightArray++)
			{
				rightArray[iRightArray] = arr[midIndex + 1 + iRightArray];
			}

			int leftIterator = 0, rightIterator = 0;
			int mergedIterator = startIndex;

			// Merge left and right arrays
			while (leftIterator < leftArrayLength && rightIterator < rightArrayLength)
			{
				if (leftArray[leftIterator] <= rightArray[rightIterator])
				{
					arr[mergedIterator] = leftArray[leftIterator];
					leftIterator++;
				}
				else
				{
					arr[mergedIterator] = rightArray[rightIterator];
					rightIterator++;
				}
				mergedIterator++;
			}

			// copy remaining from left if any
			while (leftIterator < leftArrayLength)
			{
				arr[mergedIterator] = leftArray[leftIterator];
				leftIterator++;
				mergedIterator++;
			}

			// copy remaning from right if any
			while (rightIterator < rightArrayLength)
			{
				arr[mergedIterator] = rightArray[rightIterator];
				rightIterator++;
				mergedIterator++;
			}

			PrintArray(arr);
		}
	}
}
