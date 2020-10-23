using System;
using Xunit;
using Algorithms;

namespace Algorithms.Tests
{
    public class InsertionSort_Tests
    {
        [Fact]
        public void Insertion_Sort_Test()
        {
            int[] input = { 5, 2, 4, 6, 1, 3 };
            int[] result = InsertionSort<int>.Sort(input);
            Assert.Equal(new[]{1, 2, 3, 4, 5, 6}, result);
        }
    }
}