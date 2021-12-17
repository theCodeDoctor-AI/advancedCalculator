using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using CoreLibrary;

namespace StatisticsTesting
{
    [TestClass]
    public class PercentileTests
    {
        [TestMethod]
        public void PercentileTest_Success()
        {
            // Arrange
            List<double> numbers = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double expected1 = 3;
            double expected2 = 8;
            double expected3 = 9;
            double expected4 = 1;

            // Act
            double actual1 = Statistics.Percentile(.25, numbers);
            double actual2 = Statistics.Quartile(3, numbers);
            double actual3 = Statistics.Percentile(.85, numbers);
            double actual4 = Statistics.Percentile(.1, numbers);

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }
    }
}
