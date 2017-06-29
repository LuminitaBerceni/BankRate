using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FindAndReplace
{
    [TestClass]
    public class FindAndReplaceTests
    {
        [TestMethod]
        public void ReplaceOneCharacter()
        {
            Assert.AreEqual("aba", FindAndReplace("axa", 'x', "b"));
        }

        string FindAndReplace(string initialString, char replacedCharacter, string replaceString)
        {
            return "";
        }
    }
}
