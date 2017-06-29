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
            if(initialString.Length > 0)
            {
                string finalString = FindAndReplace(initialString.Substring(1, initialString.Length - 1), replacedCharacter, replaceString);
                if (initialString[0] == replacedCharacter)
                    return replaceString + finalString;
                return initialString[0] + finalString;
            }
            return initialString;
        }
    }
}
