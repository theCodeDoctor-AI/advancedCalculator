using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreLibrary;
using System.Collections.Generic;

namespace StatisticsTesting
{
    [TestClass]
    public class MeanTests
    {
        [TestMethod]
        public void FindMeanTest_Int_Success()
        {
            // Arrange
            int[] intTest = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double expected = 5.5;

            // Act
            double actual = Statistics.FindMean(intTest);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMeanTest_Double_Success()
        {
            // Arrange
            double[] doubleTest = { 1.2, 2.3, 5.5, 4.4, 6.45, 5.42, 10.12 };
            double expected = 5.055714285714286;

            // Act
            double actual = Statistics.FindMean(doubleTest);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMeanTest_Float_Success()
        {
            // Arrange
            float[] floatTest = { 1.2f, 2.3f, 5.5f, 4.4f, 6.45f, 5.42f, 10.12f };
            float expected = 5.055714f;

            // Act
            float actual = Statistics.FindMean(floatTest);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FindMeanTest_List_Success()
        {
            // Arrange
            List<double> doubleTest = new List<double> { 1.2, 2.3, 5.5, 4.4, 6.45, 5.42, 10.12 };
            double expected = 5.055714285714286;

            // Act
            double actual = Statistics.FindMean(doubleTest);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
