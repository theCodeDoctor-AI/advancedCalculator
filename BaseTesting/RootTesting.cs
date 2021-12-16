using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using CoreLibrary;

namespace BaseTesting
{
    [TestClass]
    public class RootTesting
    {
        [TestMethod]
        public void RootTest_Success()
        {
            // Arrange
            double expected1 = 12;
            double expected2 = 16;
            double expected3 = 3.6055512754639896;

            // Act
            double actual1 = Base.SqrRoot(144);
            double actual2 = Base.SqrRoot(256);
            double actual3 = Base.SqrRoot(13);

            // Assert
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
    }
}
