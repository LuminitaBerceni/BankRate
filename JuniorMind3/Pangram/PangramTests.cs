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
            Assert.AreEqual("Yes", text );
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
