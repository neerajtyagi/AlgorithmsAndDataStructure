using System;
using Xunit;

namespace Problems.Tests
{
    public class AverageWeightOnBridge_Tests
    {
        private int[,] data = new[,] { { 0900, 1200, 200 }, { 1100, 1300, 500 }, { 1000, 1200, 200 }, { 1400, 1600, 1100 }, { 2000, 0200, 700 } };

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

        [Fact]
        public void TestAt_2100()
        {
            int averageWeight = new Problems.AverageWeightOnBridge().GetAverageWeightAtTime(data, 2100);
            Assert.Equal(averageWeight, 700);
        }

        [Fact]
        public void TestAt_0100()
        {
            int averageWeight = new Problems.AverageWeightOnBridge().GetAverageWeightAtTime(data, 0100);
            Assert.Equal(averageWeight, 700);
        }
    }
}