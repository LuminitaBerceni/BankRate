using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OperationsOnBits
{
    [TestClass]
    public class OperationsOnBitsTests
    {
        [TestMethod]
        public void ConvertToBase2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1} , ConvertNumberToAnotherBase ( 5, 2));
        }

        byte[] ConvertNumberToAnotherBase (int number, int convertedBase )
        {
            return null;
        }
    }
}
