using System;

namespace Prob_SubArrayWithGivenSum
{
    public class SubArray
    {
        public int ArrayLength { get; set; }
        public int ArraySum { get; set; }
        public int[] Array { get; set; }

        public SubArray(string format, string array)
        {
            // Check format for range and sum
            int[] formatArray = ConvertStringToFormat(format);
            this.ArrayLength = formatArray[0];
            this.ArraySum = formatArray[1];

            // Check format for array data
            this.Array = ConvertStringToArray(this.ArrayLength, array);
        }

        public int[] ConvertStringToFormat(string str)
        {
            int[] format = new int[2];
            string currentNumber = string.Empty;
            foreach (char c in str)
            {
                if (c == '0' || c == '1' || c == '2'
                || c == '3' || c == '4' || c == '5' || c == '6'
                || c == '7' || c == '8' || c == '9')
                {
                    currentNumber += c;
                }
                else if (c == ' ')
                {
                    format[0] = int.Parse(currentNumber);
                    currentNumber = string.Empty;
                }
            }

            format[1] = int.TryParse(currentNumber, out int total) ? total : 0;
            return format;
        }

        public int[] ConvertStringToArray(int length, string str)
        {
            int[] format = new int[length];
            int index = 0;
            string currentNumber = string.Empty;
            foreach (char c in str)
            {
                if (c == '0' || c == '1' || c == '2'
                || c == '3' || c == '4' || c == '5' || c == '6'
                || c == '7' || c == '8' || c == '9')
                {
                    currentNumber += c;
                }
                else if (c == ' ')
                {
                    format[index] = int.Parse(currentNumber);
                    index++;
                    currentNumber = string.Empty;
                }

                if (index > length - 1)
                {
                    break;
                }
            }

            format[index] = int.TryParse(currentNumber, out int total) ? total : 0;
            return format;
        }

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
