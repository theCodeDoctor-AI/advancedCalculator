using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CoreLibrary
{
    public static class Statistics
    {
        #region Mean
        // The raw dog method lol
        public static double Mean(params int[] numbers) 
        {
            double result = 0;
            foreach (int num in numbers)
            {
                result += num;
            }
            return result / numbers.Length;
        }

        // Achieves same as raw dog with a little linq
        public static double Mean(params double[] numbers) 
        {
            double result = numbers.Sum();
            return result / numbers.Count();
        }

        // Nice one liner
        public static float Mean(params float[] numbers) 
        {
            return numbers.Average();
        }

        // same again taking a list of doubles (can take a list of ints as well)
        public static double Mean(List<double> numbers) 
        {
            return numbers.Average();
        }
        #endregion

        #region Median
        //public double Median(params int[] numbers)
        //{
        //    double location = numbers.Length / 2;
            
        //}

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
