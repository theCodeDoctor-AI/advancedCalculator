using System;
using System.Collections.Generic;
using System.Text;
using CoreLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaseTesting
{
    [TestClass]
    public class FactorialTesting
    {
        [TestMethod]
        public void IntFactorialTest_Success()
        {
            // Arrange
            int expected1 = 24;
            int expected2 = 720;

            // Act 
            int actual1 = Base.Factorial(4);
            int actual2 = Base.Factorial(6);

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }

        [TestMethod]
        public void LongFactorialTest_Success()
        {
            // Arrange
            long expected1 = 2432902008176640000;
            long expected2 = 1307674368000;

            long first = 20;
            long second = 15;

            // Act
            long actual1 = Base.Factorial(first);
            long actual2 = Base.Factorial(second);

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
