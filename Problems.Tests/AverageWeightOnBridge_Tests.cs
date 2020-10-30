using System;
using Xunit;

namespace Problems_Tests
{
    public class AverageWeightOnBridge_Tests
    {
        private int[,] data = new int[,] { { 0900, 1200, 200 }, { 1100, 1300, 500 }, { 1000, 1200, 200 }, { 1400, 1600, 1100 } };

        [Fact]
        public void TestAt_1000()
        {
            int averageWeight = new Problems.AverageWeightOnBridge().GetAverageWeightAtTime(data, 1000);
            Assert.Equal(averageWeight, 200);
        }

        [Fact]
        public void TestAt_1100()
        {
            int averageWeight = new Problems.AverageWeightOnBridge().GetAverageWeightAtTime(data, 1100);
            Assert.Equal(averageWeight, 300);
        }
    }
}