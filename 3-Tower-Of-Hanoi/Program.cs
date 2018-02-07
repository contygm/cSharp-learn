using System;

namespace Tower_Of_Hanoi
{
    class Program
    {
        static int counter = 0;
        static void Main(string[] args)
        { 
            // TODO: add directions for user
            var discs = 0;
            Console.WriteLine("Please enter the number of discs: ");
            discs = Convert.ToInt32(Console.ReadLine());

            Tower(discs, 1, 3, 2);
        }
        
        static void Tower(int n, int sourcePeg, int destinationPeg, int sparePeg)
        {
            if (n == 1)
            {
                Console.WriteLine(counter + " " + sourcePeg + "->" + destinationPeg);
                counter++;
            }
            else
            {
                Tower(n-1, sourcePeg, sparePeg, destinationPeg);
                Console.WriteLine(counter + " " + sourcePeg + "->" + destinationPeg);
                counter++;                
                Tower(n-1, sparePeg, destinationPeg, sourcePeg);
            }

        }
    } 
}
