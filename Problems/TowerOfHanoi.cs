using System;

namespace Problems
{
    public class TowerOfHanoi
    {
        static void Main(string[] args)
        {
            int maxDiskSize = 4;
            MoveToStack(maxDiskSize, "A", "C", "B");
        }

        static void MoveToStack(int diskSize, string from, string to, string intermediate)
        {
            if (diskSize == 1)
            {
                Console.WriteLine($"Moving disk 1 from {from} to {to}");
                return;
            }

            MoveToStack(diskSize - 1, from, intermediate, to);

            Console.WriteLine($"Moving disk {diskSize} from {from} to {to}");

            MoveToStack(diskSize - 1, intermediate, to, from);
        }
    }
}