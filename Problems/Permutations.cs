using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    public class Permutations
    {
        public List<string> Solve(string data)
        {
            List<string> result = new List<string>();
            Permute(data, 0, data.Length - 1, result);
            return result;
        }

        /// <summary>
        /// Permutes the specified data with time complexity O(n*n!) 
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="left">The l.</param>
        /// <param name="right">The r.</param>
        /// <param name="result">The result.</param>
        public void Permute(string data, int left, int right, List<string> result)
        {
            if(left == right)
            {
                result.Add(data);
            }
            else
            {
                for (int index = left; index <= right; index++)
                {
                    data = Swap(data, left, index);
                    Permute(data, left + 1, right, result);
                    data = Swap(data, left, index);
                }
            }
        }

        public string Swap(string data, int index1, int index2)
        {
            char[] charString = data.ToArray();
            char c = charString[index1];
            charString[index1] = charString[index2];
            charString[index2] = c;
            return new string(charString);
        }
    }
}
