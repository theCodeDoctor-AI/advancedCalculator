using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using static CoreLibrary.Base;

namespace CoreLibrary
{
    public static class Statistics
    {
        #region Mean
        // The raw dog method lol
        public static double FindMean(params int[] numbers) 
        {
            double result = 0;
            foreach (int num in numbers)
            {
                result += num;
            }
            return result / numbers.Length;
        }

        // Achieves same as raw dog with a little linq
        public static double FindMean(params double[] numbers) 
        {
            double result = numbers.Sum();
            return result / numbers.Count();
        }

        // Nice one liner
        public static float FindMean(params float[] numbers) 
        {
            return numbers.Average();
        }

        // same again taking a list of doubles (can take a list of ints as well)
        public static double FindMean(List<double> numbers) 
        {
            return numbers.Average();
        }
        #endregion

        #region Median
        public static double Median(params int[] numbers)
        {
            double location = (numbers.Length + 1.0) / 2;
            if (CheckIfDecimal(location))
            {
                int locationInt = (int)Math.Floor(location);
                return (numbers[locationInt - 1] + numbers[locationInt]) / 2;
            }
            else
            {
                return numbers[(int)Math.Floor(location) - 1];
            }
        }

        public static double Median(params double[] numbers)
        {
            double loc = (numbers.Count() + 1.0) / 2.0;
            //int lower = (int)Math.Floor(loc);
            //int upper = (int)Math.Ceiling(loc);

            if (CheckIfDecimal(loc))
            {
                int locationInt = (int)Math.Floor(loc);
                return (numbers[locationInt - 1] + numbers[locationInt]) / 2.0;

                //double sum = numbers[lower] + numbers[upper];
                //return sum / 2.0;
            }
            else
            {
                return numbers[(int)Math.Floor(loc) - 1];
            }
        }

        public static float Median(params float[] numbers)
        {
            double loc = (numbers.Count() + 1.0) / 2.0;
            //int lower = (int)Math.Floor(loc);
            //int upper = (int)Math.Ceiling(loc);

            if (CheckIfDecimal(loc))
            {
                int locationInt = (int)Math.Floor(loc);
                return (numbers[locationInt - 1] + numbers[locationInt]) / 2.0f;

                //double sum = numbers[lower] + numbers[upper];
                //return sum / 2.0;
            }
            else
            {
                return numbers[(int)Math.Floor(loc) - 1];
            }
        }

        #endregion

        #region Mode
        // Mode
        #endregion

        #region Variance
        // Variance
        #endregion

        #region Standard Deviation
        // Standard Deviation
        #endregion

        #region Quartiles
        // Quartile 
        #endregion

        #region Percentile
        // Percentile
        #endregion

        #region Range
        // Range
        #endregion
    }
}
