using CoreLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BaseTesting
{
    [TestClass]
    public class PrimeTesting
    {
        [TestMethod]
        public void IsPrimeMethodTesting_Success()
        {
            //Arrange
            List<int> primeTest = new List<int> { 1, 3, 5, 6, 7, 9, 11, 13, 27 };
            List<bool> expected = new List<bool> { false, true, true, false, true, false, true, true, false };

            //Act
            List<bool> actual = new List<bool>();
            foreach(int num in primeTest)
            {
                actual.Add(Base.isPrime(num));
            }

            //Assert
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);                
            }
        }
    }
}
