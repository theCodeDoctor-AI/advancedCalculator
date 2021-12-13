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

        #region CheckForDecimal
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
        #endregion

        #region Power
        public static int Power(int number, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= number;
            }
            return result;
        }

        public static double Power(double number, double exponent)
        {
            double result = 1;
            for (int i = 1; i < exponent; i++)
            {
                result *= number;
            }
            return result;
        }

        #endregion

        #region Square Root
        public static double SqrRoot(int number)
        {
            return Power(number, 0.5);
        }
        #endregion
    }
}
