using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLibrary
{
    public class Base
    {
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
    }
}
