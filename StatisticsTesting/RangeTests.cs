using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using CoreLibrary;

namespace StatisticsTesting
{
    [TestClass]
    public class RangeTests
    {
        [TestMethod]
        public void RangeTest_Success()
        {
            // Arrange
            double expected1 = 9;
            double expected2 = 4;

            List<double> numbers1 = new List<double>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<double> numbers2 = new List<double>() { 1, 2, 3, 4, 5 };

            // Act
            double actual1 = Statistics.Range(numbers1);
            double actual2 = Statistics.Range(numbers2);

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
