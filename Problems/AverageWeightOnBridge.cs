using System;

namespace Problems
{
    public class AverageWeightOnBridge
    {
        public int GetAverageWeightAtTime(int[,] data, int time)
        {
            int totalWeight = 0, totalCount = 0;
            for (int record = 0; record < data.GetLength(0); record++)
            {
                if ((time >= data[record, 0] && time <= data[record, 1]) ||
                (data[record, 1] < data[record, 0] && (time >= data[record, 0] || time <= data[record, 1])))
                {
                    totalWeight += data[record, 2];
                    totalCount++;
                }
            }

            return totalCount == 0 ? 0 : totalWeight / totalCount;
        }
    }
}