using System;

namespace Fizbuzztrial
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0}", i % 15 == 0 ? "FizzBuzz" : (i % 3 == 0 ? "Fizz" : (i % 5 == 0 ? "Buzz" : i.ToString())));
            }
            Console.ReadLine();
        }
    }
}
