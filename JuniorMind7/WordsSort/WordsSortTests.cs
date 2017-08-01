using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordsSort
{
    [TestClass]
    public class WordsSortTests
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        public struct WordAppearance
        {
            public string word;
            public int appearance;
            public WordAppearance(string word, int appearance)
            {
                this.word = word;
                this.appearance = appearance;
            }
        }
    }
}
