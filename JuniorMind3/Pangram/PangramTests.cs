﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pangram
{
    [TestClass]
    public class PangramTests
    {
        [TestMethod]
        public void CheckAlphabet()
        {
            string text = CheckIfIsPangram("abcdefghijklmnopqrstuvwxyz");
            Assert.AreEqual("Yes", text );
        }


        [TestMethod]
        public void CheckIfIsNotPangram()
        {
            string text = CheckIfIsPangram("abc def");
            Assert.AreEqual("No", text);
        }

        [TestMethod]
        public void CheckOurExemple()
        {
            string text = CheckIfIsPangram("The quick brown fox jumps over the lazy dog");
            Assert.AreEqual("Yes", text);
        }

        string CheckIfIsPangram(string phrase)
        {
            for (int j = 'a'; j <= 'z'; j++)
            {
                int count = 0;
                for (int i = 0; i < phrase.Length; i++)
                {
                    if (phrase[i] == j)
                        count++;
                }
                if (count == 0)
                    return "No";
            }
            return "Yes";
        }
    }
}
