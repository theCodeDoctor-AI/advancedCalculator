using System;
using static System.Console;
using CoreLibrary;
using System.Collections.Generic;

namespace ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testing for primes
            WriteLine("Looking for Primes\n");
            List<int> primeTest = new List<int> { 1, 3, 5, 6, 7, 9, 11, 13, 27 };
            foreach (int num in primeTest)
            {
                WriteLine($"{num} - {Base.isPrime(num)}");
            }


            // Looking for isInt() solution
            WriteLine("\nIs Int\n;");
            int num1 = 5;
            double num2 = 6.0, num3 = 5.7;

            WriteLine($"{num1} % 1 = {num1 % 1}");
            WriteLine($"{num2} % 1 = {num2 % 1}");
            WriteLine($"{num3} % 1 = {num3 % 1}");
            WriteLine($"{num3} % 1 = {num3 % 1.0}");
        }
    }
}
