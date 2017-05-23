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
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1 }, ConvertNumberToAnotherBase(5, 2));
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0 }, ConvertNumberToAnotherBase(6, 2));
        }

        [TestMethod]
        public void NotOperator()
        {
            //CollectionAssert.AreEqual(ConvertNumberToAnotherBase(206, 2), NotOperation(ConvertNumberToAnotherBase(49, 2)));
            CollectionAssert.AreEqual(ConvertNumberToAnotherBase (5, 2), NotOperation(ConvertNumberToAnotherBase (2, 2)));
        }

        [TestMethod]
        public void VerifyLengthOfConvertedNumer()
        {
            Assert.AreEqual(3, GetLengthOfConvertedNumber(5, 2));
            Assert.AreEqual(2, GetLengthOfConvertedNumber(2, 2));
        }

        [TestMethod]
        public void MakeNumbersToSameLenght()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0 }, BringShorterNumberAtSameLength( ConvertNumberToAnotherBase (2,2), ConvertNumberToAnotherBase(5, 2)));
        } 

        byte[] ConvertNumberToAnotherBase (int number, int convertedBase)
        {
            byte[] convertedNumber = { };

            while (number > 0)
            {
                Array.Resize(ref convertedNumber, convertedNumber.Length + 1);
                convertedNumber[convertedNumber.Length - 1] = (byte)(number % convertedBase);
                number /= convertedBase;
            }

            Array.Reverse(convertedNumber);
            return convertedNumber;
        }

        byte[] NotOperation (byte[] arrayBaseTwo)
        {
            for (int i = 0; i < arrayBaseTwo.Length; i++)
            {
                arrayBaseTwo[i] = (byte)((arrayBaseTwo[i] == 0) ? 1 : 0);
            }
            Array.Reverse(arrayBaseTwo);
            return arrayBaseTwo;
        }

        int GetLengthOfConvertedNumber(int number, int convertedBase)
        {
            int length = 0;
            while (number > 0)
            {
                number /= convertedBase;
                length++;
            }
            return length;
        }

        byte[] BringShorterNumberAtSameLength(byte[] shortNumber, byte[] longNumber)
        {
            byte[] newNumber = new byte[] { };
            Array.Reverse(shortNumber);
            newNumber = shortNumber;
            for (int i = shortNumber.Length; i < longNumber.Length; i++)
            {
                Array.Resize(ref newNumber, newNumber.Length + 1);
                newNumber[i] = (byte) 0;
            }
            Array.Reverse(newNumber);
            return newNumber;
        }
    }
}
