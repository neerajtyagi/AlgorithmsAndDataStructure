using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_SubArrayWithGivenSum
{
    public class SubArray
    {
        public SubArray(string format, string array)
        {
            // Check format for range and sum
            string[] formatArray = format.Split(' ');
            this.ArrayLength = int.Parse(formatArray[0]);
            this.ArraySum = int.Parse(formatArray[1]);

            // Check format for array data
            string[] formatData = array.Split(' ');
            this.Array = formatData.Select(x => int.Parse(x)).ToArray();
        }

        public int ArrayLength { get; set; }
        public int ArraySum { get; set; }
        public int[] Array { get; set; }

        public void Solve()
        {
            int startIndex = 0;
            int currentIndex = 0;
            int sum = 0;
            while (startIndex < ArrayLength)
            {
                sum = 0;
                currentIndex = startIndex;
                while (currentIndex < ArrayLength && sum < ArraySum)
                {
                    sum += Array[currentIndex];
                    currentIndex++;
                }

                if (sum == ArraySum)
                {
                    break;
                }

                startIndex++;
            };

            if (sum == ArraySum)
            {
                Console.WriteLine("{0} {1}", startIndex + 1, currentIndex);
            }
            else
            {
                Console.WriteLine("-1");
            }
        }
    }
}
