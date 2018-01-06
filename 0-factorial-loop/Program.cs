using System;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the nth value as an integer: ");
            var n = Convert.ToInt32(Console.ReadLine());

            // loop calculation
            Console.WriteLine($"Factorial of {n} is {CalculateRecursive(n)}");
        }

        // LOOP: from 1 to n
        private static int CalculateLoop(int n)
        {
            var factorial = 1;
            for (int i = n; i >= 1; i--) 
            {
                factorial *= i;
            }

            return factorial;

        }

        // LOOP: from n to 1
        private static int CalculateLoop2(int n)
        {
            var factorial = n;
            for (int i = 1; i < n; i++) 
            {
                factorial *= i;
            }

            return factorial;

        }

         // RECURSION: from n to 1
        private static int CalculateRecursive(int n)
        {
            // stops the recursion
            if (n == 1)
                return 1;

            return n * CalculateRecursive(n - 1);
        }
    }
}