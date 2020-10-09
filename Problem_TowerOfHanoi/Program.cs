using System;

namespace Problem_TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxDiskSize = 4;
            TowerOfHanoi(maxDiskSize, "A", "C", "B");
        }

        static void TowerOfHanoi(int diskSize, string from, string to, string intermediate)
        {
            if(diskSize == 1)
            {
                Console.WriteLine($"Moving disk 1 from {from} to {to}");
                return;
            }

            TowerOfHanoi(diskSize - 1, from, intermediate, to);

            Console.WriteLine($"Moving disk {diskSize} from {from} to {to}");

            TowerOfHanoi(diskSize - 1, intermediate, to, from);
        }
    }
}
