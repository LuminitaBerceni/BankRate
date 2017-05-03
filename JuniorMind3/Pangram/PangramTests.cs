using System;
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
            Assert.AreEqual("Yes", text);
        }

        string CheckIfIsPangram(string phrase)
        {
            return null;
        }
    }
}
