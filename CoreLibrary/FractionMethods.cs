﻿using System;
using System.Collections.Generic;
using System.Text;
using ModelLibrary;

namespace CoreLibrary
{
    public static class FractionMethods
    {
        public static Fraction FractionSum(Fraction first, Fraction second)
        {
            Fraction sum = new Fraction();
        }

        public static Fraction FractionDifference(Fraction first, Fraction second)
        {

        }

        public static int FindLCM(Fraction first, Fraction second)
        {
            return first.Denominator * second.Denominator / FindGCD(first, second);
        }

        public static int FindGCD(Fraction first, Fraction second)
        {
            int num1 = (first.Denominator > second.Denominator) ? first.Denominator : second.Denominator;
            int num2 = (first.Denominator > second.Denominator) ? second.Denominator : first.Denominator;

            do
            {
                int remainder = num1 % num2;
                if (remainder == 0) { return num2; }

                num1 = num2;
                num2 = remainder;
            } while (true);
        }
    }
}