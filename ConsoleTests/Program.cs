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
            List<int> primeTest = new List<int> { 1, 3, 5, 6, 7, 9, 11, 13, 27 };
            foreach (int num in primeTest)
            {
                WriteLine($"{num} - {Base.isPrime(num)}");
            }
        }
    }
}
