using System;
using System.Collections.Generic;
using System.Text;
using CoreLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatisticsTesting
{
    [TestClass]
    public class MedianTest
    {
        [TestMethod]
        public void TestMedian_Success()
        {
            // Arrange
            int[] numbers1 = { 1, 2, 3, 4, 5 };
            double[] numbers2 = { 1.2, 2.4, 3.6, 4.5, 5.7 };

            int[] numbers3 = { 2, 6, 9, 15, 18, 20 };
            float[] numbers4 = { 2.2f, 6.4f, 9.7f, 15.2f, 18.3f, 20.5f };

            int expected1 = 3;
            double expected2 = 3.6;
            int expected3 = 12;
            float expected4 = 12.45f;

            // Act 
            double actual1 = Statistics.Median(numbers1);
            double actual2 = Statistics.Median(numbers2);
            double actual3 = Statistics.Median(numbers3);
            float actual4 = Statistics.Median(numbers4);

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }
    }
}
