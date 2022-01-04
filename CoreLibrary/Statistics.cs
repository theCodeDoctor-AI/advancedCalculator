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

        public static double FindMean(List<int> numbers)
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
                return (numbers[locationInt - 1] + numbers[locationInt]) / 2.0;
            }
            else
            {
                return numbers[(int)Math.Floor(location) - 1];
            }
        }

        public static double Median(params double[] numbers)
        {
            double loc = (numbers.Count() + 1.0) / 2.0;

            if (CheckIfDecimal(loc))
            {
                int locationInt = (int)loc;
                return (numbers[locationInt - 1] + numbers[locationInt]) / 2.0;
            }
            else
            {
                return numbers[(int)loc - 1];
            }
        }

        public static float Median(params float[] numbers)
        {
            double loc = (numbers.Count() + 1.0) / 2.0;

            if (CheckIfDecimal(loc))
            {
                int locationInt = (int)loc;
                return (numbers[locationInt - 1] + numbers[locationInt]) / 2.0f;
            }
            else
            {
                return numbers[(int)loc- 1];
            }
        }

        public static double Median(List<int> numbers)
        {
            double location = (numbers.Count + 1.0) / 2;
            if (CheckIfDecimal(location))
            {
                int locationInt = (int)location;
                return (numbers[locationInt - 1] + numbers[locationInt]) / 2.0;
            }
            else
            {
                return numbers[(int)location - 1];
            }
        }

        #endregion

        #region Mode       
        //public static List<int> Mode(List<int> numbers)
        //{
        //    var groups = numbers.GroupBy(n => n);
        //    int maxCount = groups.Max(g => g.Count());
        //    int mode = groups.First(g => g.Count() == maxCount).Key;
        //}

        //public static List<double> Mode(List<double> numbers)
        //{
        //    List<double> highestFreqDigits = new List<double>();
        //    double highFreq = 0.0;
        //    foreach (int num in numbers)
        //    {
        //        int indexFreq = numbers.Count(x => x == num);

        //        if (indexFreq >= highFreq)
        //        {
        //            if (indexFreq == highFreq)
        //            {
        //                if (!highestFreqDigits.Contains(num))
        //                {
        //                    highestFreqDigits.Add(num);
        //                }
        //            }
        //            else
        //            {
        //                highFreq = indexFreq;
        //                highestFreqDigits.Clear();
        //                highestFreqDigits.Add(num);
        //            }
        //        }
        //    }
        //    return highestFreqDigits;
        //}

        //public static List<float> Mode(List<float> numbers)
        //{
        //    List<float> highestFreqDigits = new List<float>();
        //    float highFreq = 0.0f;
        //    foreach (int num in numbers)
        //    {
        //        int indexFreq = numbers.Count(x => x == num);

        //        if (indexFreq >= highFreq)
        //        {
        //            if (indexFreq == highFreq)
        //            {
        //                if (!highestFreqDigits.Contains(num))
        //                {
        //                    highestFreqDigits.Add(num);
        //                }
        //            }
        //            else
        //            {
        //                highFreq = indexFreq;
        //                highestFreqDigits.Clear();
        //                highestFreqDigits.Add(num);
        //            }
        //        }
        //    }
        //    return highestFreqDigits;
        //}
        #endregion

        #region Variance
        public static double Variance(List<int> numbers)
        {
            double summation = 0.0;
            foreach(int num in numbers)
            {
                summation += Power(num, 2);
            }
            double result = summation / (numbers.Count - 1);
            return result;
        }
        #endregion

        #region Standard Deviation
        public static double Stddev(List<int> numbers)
        {
            return SqrRoot(Variance(numbers));          
        }
        #endregion

        #region Quartiles
        public static double Quartile(int quartile, List<double> numbers)
        {
            if(quartile == 1) { return Percentile(0.25, numbers); }
            if(quartile == 2) { return Percentile(0.50, numbers); }
            if(quartile == 3) { return Percentile(0.75, numbers); }
            return 0.0;
        }

        public static double Quartile(int quartile, List<int> numbers)
        {
            if (quartile == 1) { return Percentile(0.25, numbers); }
            if (quartile == 2) { return Percentile(0.50, numbers); }
            if (quartile == 3) { return Percentile(0.75, numbers); }
            return 0.0;
        }

        #endregion

        #region Percentile
        public static double Percentile(double percentile, List<double> numbers)
        {
            double location = percentile * numbers.Count;
            if(!CheckIfDecimal(location))
            {
                return (numbers[(int)Math.Ceiling(location) - 1] + numbers[(int)Math.Ceiling(location)]) / 2.0;
            }
            return numbers[(int)Math.Floor(location) - 1];
        }

        public static double Percentile(double percentile, List<int> numbers)
        {
            double location = percentile * numbers.Count;
            if (!CheckIfDecimal(location))
            {
                return (numbers[(int)Math.Ceiling(location) - 1] + numbers[(int)Math.Ceiling(location)]) / 2.0;
            }
            return numbers[(int)Math.Floor(location) - 1];
        }
        #endregion

        #region Range
        public static double Range(List<double> numbers)
        {
            return numbers.Max() - numbers.Min();
        }

        public static int Range(List<int> numbers)
        {
            return numbers.Max() - numbers.Min();
        }    
        #endregion
    }
}
