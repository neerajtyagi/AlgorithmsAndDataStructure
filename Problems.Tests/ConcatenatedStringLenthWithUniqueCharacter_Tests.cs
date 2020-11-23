using System;
using Problems;
using Xunit;

namespace Problems.Tests
{
    public class ConcatenatedStringLenthWithUniqueCharacter_Tests
    {
        [Theory]
        [InlineData(new string[] { "un", "iq", "ue" }, 4)]
        [InlineData(new string[] { "cha", "r", "act", "ers" }, 6)]
        [InlineData(new string[] { "abcdefghijklmnopqrstuvwxyz" }, 26)]
        [InlineData(new string[] { "abcdefgh" }, 8)]
        [InlineData(new string[] { "", "ab", "cd", "abcd", "cdab" }, 4)]
        [InlineData(new string[] { "ab", "cd", "ab" }, 4)]
        [InlineData(new string[] { "co", "dil", "ity" }, 5)]
        [InlineData(new string[] { "abc", "kkk", "def", "csv" }, 6)]
        [InlineData(new string[] { "abc", "ade", "akl" }, 3)]
        public void ValidatConcatenatedStringLenthWithUniqueCharacter(string[] data, int result)
        {
            ConcatenatedStringLenthWithUniqueCharacter obj = new ConcatenatedStringLenthWithUniqueCharacter();
            Assert.Equal(obj.Solve(data), result);
        }
    }
}