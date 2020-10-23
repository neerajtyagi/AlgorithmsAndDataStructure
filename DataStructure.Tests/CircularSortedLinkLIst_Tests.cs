using System;
using Xunit;
using Xunit.Abstractions;

namespace DataStructure.Tests
{
    public class CircularSortedLinkList_Tests
    {
        [Fact]
        public void SampleTestMethod()
        {
            CircularSortedLinkList<int> circularLinkList = new CircularSortedLinkList<int>(20);
            int[] result = circularLinkList.ToArray();
            Assert.Equal(new int[] { 20 }, result);

            circularLinkList.Add(40);
            result = circularLinkList.ToArray();
            Assert.Equal(new int[] { 20, 40 }, result);

            circularLinkList.Add(30);
            result = circularLinkList.ToArray();
            Assert.Equal(new int[] { 20, 30, 40 }, result);

            circularLinkList.Add(20);
            result = circularLinkList.ToArray();
            Assert.Equal(new int[] { 20, 20, 30, 40 }, result);

            circularLinkList.Add(50);
            result = circularLinkList.ToArray();
            Assert.Equal(new int[] { 20, 20, 30, 40, 50 }, result);

            circularLinkList.Add(10);
            result = circularLinkList.ToArray();
            Assert.Equal(new int[] { 20, 20, 30, 40, 50, 10 }, result);

            // Change current node as 10
            var newlist = circularLinkList.Next.Next.Next.Next.Next;
            newlist.Add(60);
            result = newlist.ToArray();
            Assert.Equal(new int[] { 10, 20, 20, 30, 40, 50, 60 }, result);
        }
    }
}
