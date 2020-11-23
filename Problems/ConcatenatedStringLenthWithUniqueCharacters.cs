using System;

namespace Problems
{
    public class ConcatenatedStringLenthWithUniqueCharacter
    {
        public int Solve(string[] input)
        {
            int maxLenth = 0;
            ConcatenatedString(input, 0, string.Empty, ref maxLenth);
            return maxLenth;
        }

        private void ConcatenatedString(string[] input, int index, string concatString, ref int maxLenth)
        {
            if (index == input.Length && UniqueCharacterString(concatString) > maxLenth)
            {
                maxLenth = concatString.Length;
                return;
            }

            if(index == input.Length)
            {
                return;
            }

            ConcatenatedString(input, index + 1, concatString, ref maxLenth);
            ConcatenatedString(input, index + 1, concatString + input[index], ref maxLenth);
        }

        public int UniqueCharacterString(string concatString)
        {
            int[] chars = new int[26];
            for (int index = 0; index < concatString.Length; index++)
            {
                if (chars[concatString[index] - 'a'] > 0)
                {
                    return -1;
                }
                else
                {
                    chars[concatString[index] - 'a']++;
                }
            }

            return concatString.Length;
        }
    }
}