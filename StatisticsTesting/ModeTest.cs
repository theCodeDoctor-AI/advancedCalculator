using System;
using System.Collections.Generic;
using System.Text;
using CoreLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StatisticsTesting
{
    [TestClass]
    public class ModeTest
    {
        [TestMethod]
        public void ModeTestInt_Success()
        {
            //Arrange
            List<int> numbers1 = new List<int>() { 1, 2, 2, 3, 4, 5, 6, 5 };
            List<int> expected = new List<int>() { 2, 5 };

            //Act 
            List<int> actual = Statistics.Mode(numbers1);
            actual.Sort();

            //Assert
            for(int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void ModeTestDouble_Success()
        {
            //Arrange
            List<double> numbers1 = new List<double>() { 1.0, 2.0, 2.0, 3.0, 4.0, 5.0, 6.0, 5.0 };
            List<double> expected = new List<double>() { 2.0, 5.0 };

            //Act 
            List<double> actual = Statistics.Mode(numbers1);
            actual.Sort();

            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }

        [TestMethod]
        public void ModeTestFloat_Success()
        {
            //Arrange
            List<float> numbers1 = new List<float>() { 1f, 2f, 2f, 3f, 4f, 5f, 6f, 5f };
            List<float> expected = new List<float>() { 2f, 5f };

            //Act 
            List<float> actual = Statistics.Mode(numbers1);
            actual.Sort();

            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
