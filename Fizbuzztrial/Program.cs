using FizzBuzz;
using System;
namespace FizzBuzzProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Maximum Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            FizzBuzzClass result = new FizzBuzzClass();
            result.FizzBuzz(number);
            Console.ReadLine();
        }
    }
}
