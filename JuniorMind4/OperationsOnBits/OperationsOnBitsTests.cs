using System;
using System.Collections;
using Xunit;

namespace OperationsOnBits
{
    
    public class OperationsOnBitsTests
    {
        [Fact]
        public void ConvertToBase2()
        {
            Assert.Equal(new byte[] { 1, 0, 1 }, ConvertToBinary(5));
            Assert.Equal(new byte[] { 1, 1, 0 }, ConvertToBinary(6));

            Assert.Equal(new byte[] { 1, 1, 0, 0, 0, 1 }, ConvertToBinary(49));
            Assert.Equal(new byte[] { 1, 1, 0, 0, 1, 1, 1, 0 }, ConvertToBinary(206));
        }

        [Fact]
        public void NotOperator()
        {
            Assert.Equal(ConvertToBinary(2), NotOperation(ConvertToBinary(5)));
        }

        [Fact]
        public void RemoveZeroes()
        {
            Assert.Equal(new byte[] { 1 }, RemoveLeadingZeroes(new byte[] { 0, 1 }));
        }

        [Fact]
        public void GetElementFromGivenPosition()
        {
            Assert.Equal(2, GetAt ( new byte[] { 1, 2, 3, 4} , 2 ) );
            Assert.Equal(0, GetAt( new byte[] { 1, 2, 3, 4 }, 5));
        }

        [Fact]
        public void LogicOperationOR()
        {
            byte[] firstNumber = ConvertToBinary(5);
            byte[] secondNumber = ConvertToBinary(3);
            Assert.Equal(ConvertToBinary(7), LogicOperation(firstNumber, secondNumber, "OR"));
        }

        [Fact]
        public void LogicOperationAND()
        {
            byte[] firstNumber = ConvertToBinary(5);
            byte[] secondNumber = ConvertToBinary(3);
            Assert.Equal(ConvertToBinary(1), LogicOperation(firstNumber, secondNumber, "AND"));
        }

        [Fact]
        public void LogicOperationXOR()
        {
            byte[] firstNumber = ConvertToBinary(5);
            byte[] secondNumber = ConvertToBinary(3);
            Assert.Equal(ConvertToBinary(6), LogicOperation(firstNumber, secondNumber, "XOR"));
        }

        [Fact]
        public void RightShift()
        {
            Assert.Equal(ConvertToBinary(5 >> 2), RightHandShift(ConvertToBinary(5), 2));
            Assert.Equal(ConvertToBinary(8 >> 3), RightHandShift(ConvertToBinary(8), 3));
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

        byte[] ConvertToBinary(int number)
        {
            return ConvertNumberToAnotherBase(number, 2);
        }

        byte[] NotOperation (byte[] arrayBaseTwo)
        {
            for (int i = 0; i < arrayBaseTwo.Length; i++)
            {
                arrayBaseTwo[i] = (byte)((arrayBaseTwo[i] == 0) ? 1 : 0);
            }
            return RemoveLeadingZeroes(arrayBaseTwo);
        }

        byte[] RemoveLeadingZeroes(byte[] number)
        {
            byte[] result = new byte[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] > 0)
                {
                    Array.Resize(ref result, number.Length - i);
                    for (int j = 0; j < result.Length; j++)
                    {
                        result[j] = number[i + j];
                    }
                    break;
                }
            }
            return result;
        }

        byte GetAt(byte[] binaryNumber, int position)
        {
            if (position >= 0 && position < binaryNumber.Length)
                return binaryNumber[binaryNumber.Length - position - 1];
            return 0;
        }

        public byte[] LogicOperation(byte[] firstNumber, byte[] secondNumber, string operation)
        {
            byte[] result = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                byte first = GetAt(firstNumber, i);
                byte second = GetAt(secondNumber, i);
                switch (operation)
                {
                    case "OR":
                        result[i] = OR(first, second);
                        break;
                    case "AND":
                        result[i] = AND(first, second);
                        break;
                    case "XOR":
                        result[i] = XOR(first, second);
                        break;
                }
            }
            Array.Reverse(result);
            return RemoveLeadingZeroes (result);

        }

        private static byte XOR(byte first, byte second)
        {
            return first != second ? (byte)1 : (byte)0;
        }

        private static byte AND(byte first, byte second)
        {
            return first == 1 && second == 1 ? (byte)1 : (byte)0;
        }

        private static byte OR(byte first, byte second)
        {
            return first == 0 && second == 0 ? (byte)0 : (byte)1;
        }

        byte[] RightHandShift(byte[] number, int positions)
        { 
            Array.Resize(ref number, number.Length - positions);
            return number;
        }

    }
}
