//JOhn Denver Balagwis
//BSI/T- 2F
//Create a program for implementation in tower of Hanoi using any programming language.
using System;

namespace BalagwisJohnDenverTowerofHanoi
{
    internal static class Program
    {
        private static void TowerofHanoi(int disk, char source, char destination, char auxillary)
        {
            if (disk == 1)
            {
                Console.WriteLine($"\nMove Disc 1 from pole {source} to pole {destination}");
            }
            else
            {
                TowerofHanoi(disk - 1, source, auxillary, destination);
                Console.WriteLine($"\nMove disk {disk} from pole {source} to pole {destination}");
                TowerofHanoi(disk - 1, auxillary, destination, source);
            }
        }

        private static void Main(string[] args)
        {
            int numOfDisks;
            Console.Write("Enter no. of Disks: ");
            numOfDisks = Convert.ToInt32(Console.ReadLine());

            //A is Source, B is Auxiliary  and C is for Destination
            TowerofHanoi(numOfDisks, 'A', 'C', 'B');
            Console.ReadLine();
        }
    }
}