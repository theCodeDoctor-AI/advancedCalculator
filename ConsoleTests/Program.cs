﻿using System;
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
            int actual1 = Statistics.Median(numbers1);
            WriteLine($"{expected1}{actual1}");

            int[] numbers3 = { 2, 6, 9, 15, 18, 20 };
            int expected3 = 13;
            int actual3 = Statistics.Median(numbers3);
        }
    }
}
