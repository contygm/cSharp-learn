﻿using System;
using System.Text;

// Solve with loop and Recusrion
// - Print numbers 1-100
// - Numbers divisble by 3 print Fizz
// - Numbers divisble by 5 print Buzz
// - Numbers divisble by 3 & 5 print FizzBuzz

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop();
            Recursion(1);
        }

        private static void Loop()
        {
            var n = 0;
            while (n++ < 100)
            {
                if (n % 3 == 0 && n % 5 == 0)
                    Console.WriteLine("Fizz Buzz");
                else if (n % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (n % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine($"{n}");
            }

            return;
        }

        private static void Recursion(int n)
        {
            if (n > 100)
                return;

            if (n % 3 == 0 && n % 5 == 0)
                Console.WriteLine("Fizz Buzz");
            else if (n % 3 == 0)
                Console.WriteLine("Fizz");
            else if (n % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine($"{n}");
            
            Recursion(n + 1); 
        }
    }
}
