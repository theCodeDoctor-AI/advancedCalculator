using System;
using System.Collections.Generic;
using CoreLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseTesting
{
    [TestClass]
    public class CheckDecimalsTest
    {
        [TestMethod]
        public void TestCheckDecimal_Success()
        {
            //Arrange
            int num1 = 5;
            double num2 = 6.0, num3 = 5.7, num4 = 5.2;
            float num5 = 5.4f;
            bool expected1 = false;
            bool expected2 = false;
            bool expected3 = true;
            bool expected4 = true;
            bool expected5 = true;

            // Act
            bool actual1 = Base.CheckIfDecimal(num1);
            bool actual2 = Base.CheckIfDecimal(num2);
            bool actual3 = Base.CheckIfDecimal(num3);
            bool actual4 = Base.CheckIfDecimal(num4);
            bool actual5 = Base.CheckIfDecimal(num5);

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
            Assert.AreEqual(expected5, actual5);
        }
    }
}
