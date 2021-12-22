using System;
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
            if(first.Denominator == second.Denominator)
            {
                sum.Numerator = first.Numerator + second.Numerator;
                sum.Denominator = first.Denominator;
            }
            else
            {
                AlignDenomitors(first, second);
                sum.Numerator = first.Numerator + second.Numerator;
                sum.Denominator = first.Denominator;
            }
            return sum;
        }

        public static Fraction FractionDifference(Fraction first, Fraction second)
        {
            Fraction diff = new Fraction();
            if (first.Denominator == second.Denominator)
            {
                diff.Numerator = first.Numerator - second.Numerator;
                diff.Denominator = first.Denominator;
            }
            else
            {
                AlignDenomitors(first, second);
                diff.Numerator = first.Numerator - second.Numerator;
                diff.Denominator = first.Denominator;
            }
            return diff;
        }

        public static Fraction FractionProduct(Fraction first, Fraction second)
        {
            Fraction product = new Fraction();
            product.Numerator = first.Numerator * second.Numerator;
            product.Denominator = first.Numerator * second.Numerator;

            return product;
        }

        public static Fraction FractionQuotient(Fraction first, Fraction second)
        {
            Fraction quotient = new Fraction();
            quotient.Numerator = first.Numerator * second.Denominator;
            quotient.Denominator = first.Denominator * second.Numerator;

            return quotient;
        }

        public static void AlignDenomitors(Fraction first, Fraction second)
        {
            int LCM = FindLCM(first, second);

            int firstMultiplier = LCM / first.Denominator;
            int secondMultiplier = LCM / second.Denominator;

            first.Numerator *= firstMultiplier;
            first.Denominator *= firstMultiplier;

            second.Numerator *= secondMultiplier;
            second.Denominator *= secondMultiplier;
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
