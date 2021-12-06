using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLibrary
{
    public static class Base
    {
        #region Prime Methods
        // Check if number is prime
        public static bool isPrime(int number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }
            for(int i = number - 1; i > 1;  i--)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // Prime Factorization

        // Build List of Primes
        #endregion

        #region Factorial Methods
        // For Large Numbers
        public static long Factorial(long number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            for(long i = number - 1; i > 1; i--)
            {
                number *= i;
            }
            return number;
        }

        // For Smaller Numbers
        public static int Factorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            for (int i = number - 1; i > 1; i--)
            {
                number *= i;
            }
            return number;
        }
        #endregion

        // Clearly typed method
        public static bool CheckIfDecimal(double number) 
        {
            if (number % 1 == 0)
            {
                return false;
            }
            return true;
        }

        // A little crafty
        public static bool CheckIfDecimal(float number)
        {
            return (number % 1 == 0) ? false : true;
        }

        public static bool CheckIfDecimal(int number)
        {
            return (number % 1 == 0) ? false : true;
        }
    }
}
