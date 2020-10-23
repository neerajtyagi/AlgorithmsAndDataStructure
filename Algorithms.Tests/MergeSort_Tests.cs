using System;
using Xunit;
using Algorithms;

namespace Algorithms.Tests
{
    public class MergeSort_Tests
    {
        [Fact]
        public void Merge_Sort_Test()
        {
            int[] input = { 5, 2, 4, 9, 7, 1, 3, 2, 6 };
            int[] result = MergeSort<int>.Sort(input);
            Assert.Equal(new[]{1, 2, 2, 3, 4, 5, 6, 7, 9}, result);
        }
    }
}