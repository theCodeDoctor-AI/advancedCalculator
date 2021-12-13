using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoreLibrary;

namespace BaseTesting
{
    [TestClass]
    public class PowerTesting
    {
        [TestMethod]
        public void PowerTest_Success()
        {
            // Arrange 
            int expected1 = 64;
            int expected2 = 128;

            // Act 
            int actual1 = Base.Power(4, 3);
            int actual2 = Base.Power(2, 7);

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
