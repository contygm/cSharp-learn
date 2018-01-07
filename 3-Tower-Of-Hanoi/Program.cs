using System;

namespace Tower_Of_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        
        static void Tower(int n, int sourcePeg, int middlePeg, int destinationPeg)
        {
            if (n == 1)
            {
                Console.WriteLine(sourcePeg + "->" + destinationPeg);
            }
            else
            {
                
            }

        }
    } 
}
