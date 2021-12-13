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

            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int expected1 = 3;
            double actual1 = Statistics.Median(numbers1);
            WriteLine($"{expected1}{actual1}");

            int[] numbers3 = { 2, 6, 9, 15, 18, 20 };
            int expected3 = 12;
            double actual3 = Statistics.Median(numbers3);
            WriteLine($"{expected3}, {actual3}");

            List<int> listInts = new List<int>() { 1, 2, 2, 3, 4, 5, 6, 5 };
            List<int> expected = new List<int>() { 2, 5 };

            int powerResult = Base.Power(4, 3);
            WriteLine(powerResult);

            WriteLine($"Square root of 144 is: {Base.SqrRoot(144)}");
        }
    }
}
