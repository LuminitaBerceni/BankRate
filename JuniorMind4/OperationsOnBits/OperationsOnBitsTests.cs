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

            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0, 0, 1 }, ConvertNumberToAnotherBase(49, 2));
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0, 1, 1, 1, 0 }, ConvertNumberToAnotherBase(206, 2));
        }

        [TestMethod]
        public void NotOperator()
        {
            byte[] inversedNumber2 = NotOperation(ConvertNumberToAnotherBase(49, 2));
            byte[] shortNumberWithSameLength2 = BringShorterNumberAtSameLength(ConvertNumberToAnotherBase(206, 2), inversedNumber2);
            CollectionAssert.AreEqual(ConvertNumberToAnotherBase(206, 2), shortNumberWithSameLength2);

            byte[] inversedNumber1 = NotOperation(ConvertNumberToAnotherBase(2, 2));
            byte[] shortNumberWithSameLength1 = BringShorterNumberAtSameLength(ConvertNumberToAnotherBase(5, 2), inversedNumber1);
            CollectionAssert.AreEqual(ConvertNumberToAnotherBase (5, 2), shortNumberWithSameLength1);
        }

        [TestMethod]
        public void VerifyLengthOfConvertedNumer()
        {
            Assert.AreEqual(3, GetLengthOfConvertedNumber(5, 2));
            Assert.AreEqual(2, GetLengthOfConvertedNumber(2, 2));

            Assert.AreEqual(6, GetLengthOfConvertedNumber(49, 2));
            Assert.AreEqual(8, GetLengthOfConvertedNumber(206, 2));
        }

        [TestMethod]
        public void MakeNumbersToSameLenght()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0 }, BringShorterNumberAtSameLength( ConvertNumberToAnotherBase (2,2), ConvertNumberToAnotherBase(5, 2)));
            CollectionAssert.AreEqual(new byte[] { 0, 0, 1, 1, 0, 0, 0, 1 }, BringShorterNumberAtSameLength(ConvertNumberToAnotherBase(49, 2), ConvertNumberToAnotherBase(206, 2)));
        }

        [TestMethod]
        public void GetElementFromGivenPosition()
        {
            Assert.AreEqual(2, GetAt ( new byte[] { 1, 2, 3, 4} , 2 ) );
            Assert.AreEqual(0, GetAt(new byte[] { 1, 2, 3, 4 }, 5));
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

        byte GetAt(byte[] binaryNumber, int position)
        {
            if (position >= 0 && position < binaryNumber.Length)
                return binaryNumber[binaryNumber.Length - position - 1];
            return 0;
        }
    }
}
