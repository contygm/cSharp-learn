using System;

namespace Sieve_of_Erasthenes
{
    class Program
    {
        static bool[] allNumbers;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number 'n' : ");
            var n = Convert.ToInt32(Console.ReadLine());
            var arrSize = n + 1;
            CreateArray(arrSize);
            Sieve(arrSize);
        }

        static void Sieve(int n)
        {
          // check if divisable by 2
          //
          for (int i = 2; i < n; i++)
          {
            if(allNumbers[i])
            {
              // i * c < n
              // check that mulitple is less than n (array size)
              //
              for (int c = i; i * c < n; c++)
              {
                // check if array is mulitple of i
                // mark false if yes
                //
                allNumbers[i * c] = false;
              }
            }
          }
          // display only prime numbers -> index == true
          //
          var counter = 0;
          for (int i = 2; i < n; i++)
          {
            if(allNumbers[i])
            {
              Console.Write(i + " ");
              counter++;
            }

            // only 10 numbers per line
            //
            if (counter == 10) {
              Console.Write("\n");
              counter = 0;
            }
          }
          Console.Write("\n");
        }

        static void CreateArray(int n)
        {
          allNumbers = new bool[n];

          for (int i = 0; i < n; i ++)
          {
            allNumbers[i] = true;
          }
        }
    }
}
