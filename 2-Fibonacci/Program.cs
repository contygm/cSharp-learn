using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!! FIBONACCI !!");
            Loop();
        }

        private static void Loop()
        {
            var num1 = 0;
            var num2 = 1;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
            
            while (num1 < 100)
            {
                var num3 = num1 + num2;
                num1 = num2;
                num2 = num3;
                Console.WriteLine(num3);
            }
        }
    }
}
