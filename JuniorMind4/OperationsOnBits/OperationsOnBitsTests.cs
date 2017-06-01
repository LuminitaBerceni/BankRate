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
            Assert.Equal(new byte[] { 1, 0, 1 }, RemoveLeadingZeroes(new byte[] { 0, 1, 0, 1 }));
        }

        [Fact]
        public void GetElementFromGivenPosition()
        {
            Assert.Equal(2, GetAt(new byte[] { 1, 2, 3, 4 }, 2));
            Assert.Equal(0, GetAt(new byte[] { 1, 2, 3, 4 }, 5));
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

        [Fact]
        public void LeftShift()
        {
            Assert.Equal(ConvertToBinary(5 << 2), LeftHandShift(ConvertToBinary(5), 2));
            Assert.Equal(ConvertToBinary(8 << 3), LeftHandShift(ConvertToBinary(8), 3));
        }

        [Fact]
        public void Sum()
        {
            Assert.Equal(ConvertToBinary(8), Sum(ConvertToBinary(5), ConvertToBinary(3)));
            Assert.Equal(ConvertToBinary(142), Sum(ConvertToBinary(127), ConvertToBinary(15)));
        }

        [Fact]
        public void Difference()
        {
            Assert.Equal(ConvertToBinary(2), Difference(ConvertToBinary(5), ConvertToBinary(3)));
            Assert.Equal(ConvertToBinary(6), Difference(ConvertToBinary(10), ConvertToBinary(4)));
            Assert.Equal(ConvertToBinary(12), Difference(ConvertToBinary(17), ConvertToBinary(5)));
        }

        [Fact]
        public void CheckLessThan()
        {
            Assert.Equal(true, LessThan(ConvertToBinary(3), ConvertToBinary(5)));
            Assert.Equal(false, LessThan(ConvertToBinary(5), ConvertToBinary(5)));
            Assert.Equal(true, LessThan(ConvertToBinary(8), ConvertToBinary(12)));
        }

        [Fact]
        public void CheckGreaterThan()
        {
            Assert.Equal(false, GreaterThan(ConvertToBinary(3), ConvertToBinary(5)));
            Assert.Equal(false, GreaterThan(ConvertToBinary(5), ConvertToBinary(5)));
            Assert.Equal(true, GreaterThan(ConvertToBinary(5), ConvertToBinary(3)));
        }

        [Fact]
        public void CheckAreEqual()
        {
            Assert.Equal(false, AreEqual(ConvertToBinary(3), ConvertToBinary(5)));
            Assert.Equal(true, AreEqual(ConvertToBinary(5), ConvertToBinary(5)));
        }

        [Fact]
        public void CheckIfAreNotEqual()
        {
            Assert.Equal(true, AreNotEqual(ConvertToBinary(3), ConvertToBinary(5)));
            Assert.Equal(false, AreNotEqual(ConvertToBinary(5), ConvertToBinary(5)));
        }

        [Fact]
        public void Multiplication()
        {
            Assert.Equal(ConvertToBinary(6), Multiply(ConvertToBinary(3), ConvertToBinary(2)));
            Assert.Equal(ConvertToBinary(28), Multiply(ConvertToBinary(7), ConvertToBinary(4)));
        }

        [Fact]
        public void Division()
        {
            Assert.Equal(ConvertToBinary(3), Division(ConvertToBinary(6), ConvertToBinary(2)));
            Assert.Equal(ConvertToBinary(7), Division(ConvertToBinary(28), ConvertToBinary(4)));
        }

        byte[] ConvertNumberToAnotherBase(int number, int convertedBase)
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

        byte[] NotOperation(byte[] arrayBaseTwo)
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
            return RemoveLeadingZeroes(result);

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

        byte[] LeftHandShift(byte[] number, int positions)
        {
            byte[] result = new byte[number.Length + positions];
            for (int i = 0; i < number.Length; i++)
            {
                result[i] = number[i];
            }
            return result;
        }

        byte[] Sum(byte[] first, byte[] second)
        {
            var result = new byte[Math.Max(first.Length, second.Length)];
            int numberToRemember = 0;
            for (int i = 0; i < result.Length; i++)
            {
                var sum = GetAt(first, i) + GetAt(second, i) + numberToRemember;
                result[i] = (byte)(sum % 2);
                numberToRemember = sum / 2;
            }

            if (numberToRemember != 0)
            {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = (byte)numberToRemember;
            }
            Array.Reverse(result);
            return result;
        }

        byte[] Difference(byte[] first, byte[] second)
        {

            byte[] result = new byte[first.Length];
            int numberToRemember = 0;
            for (int i = 0; i < first.Length; i++)
            {
                int difference = (byte)(2 + (GetAt(first, i) - GetAt(second, i) - numberToRemember));
                result[result.Length - i - 1] = (byte)(difference % 2);

                if (difference < 2) numberToRemember = 1;
                else numberToRemember = 0;
            }
            return RemoveLeadingZeroes(result);
        }

        bool LessThan(byte[] first, byte[] second)
        {
            for (int i = Math.Max(first.Length, second.Length) - 1; i >= 0; i--)
            {
                if (GetAt(first, i) != GetAt(second, i))
                    return GetAt(first, i) < GetAt(second, i);
            }
            return false;
        }

        bool GreaterThan(byte[] first, byte[] second)
        {
            for (int i = Math.Max(first.Length, second.Length) - 1; i >= 0; i--)
            {
                if (GetAt(first, i) != GetAt(second, i))
                    return GetAt(first, i) > GetAt(second, i);
            }
            return false;
        }

        bool AreEqual(byte[] first, byte[] second)
        {
            return !LessThan(first, second) && !GreaterThan(first, second);
        }

        bool AreNotEqual(byte[] first, byte[] second)
        {
            return !AreEqual(first, second);
        }

        byte[] Multiply (byte[] first, byte[] second)
        {
            byte[] result = new byte[Math.Max(first.Length, second.Length)];
            do
            {
                result = Sum(result, first);
                second = Difference(second, ConvertToBinary(1));
            }
            while (AreNotEqual(second, ConvertToBinary(0)));
            return RemoveLeadingZeroes (result);
        }

        byte[] Division(byte[] first, byte[] second)
        {
            int divisionCounter = 0;
            while (AreNotEqual(first, ConvertToBinary(0)))
            {
                first = Difference(first, second);
                divisionCounter++;
            }
            return ConvertToBinary(divisionCounter);
        }
    }
}
