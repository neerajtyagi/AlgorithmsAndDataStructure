using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Problems.Tests
{
    public class Permutations_Tests
    {
        [Fact]
        public void Validate_Permutations()
        {
            string input = "ABC";
            Permutations permutations = new Permutations();
            List<string> result = permutations.Solve(input);
            Assert.Contains("ABC", result);
            Assert.Contains("ACB", result);
            Assert.Contains("BAC", result);
            Assert.Contains("BCA", result);
            Assert.Contains("CBA", result);
            Assert.Contains("CAB", result);
        }
    }
}