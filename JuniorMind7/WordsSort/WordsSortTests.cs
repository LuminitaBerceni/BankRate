using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WordsSort
{
    [TestClass]
    public class WordsSortTests
    {
        [TestMethod]
        public void SortTextWithTwoWords()
        {
            var result = new WordAppearance[]
            {
                new WordAppearance("ana", 2),
                new WordAppearance("si", 1)
            };
            CollectionAssert.AreEqual(result, FindAndSortWordsByAppearances("ana si ana"));
        }

        public struct WordAppearance
        {
            public string word;
            public int appearances;
            public WordAppearance(string word, int appearances)
            {
                this.word = word;
                this.appearances = appearances;
            }
        }

        WordAppearance[] FindAndSortWordsByAppearances(string text)
        {
            return new WordAppearance[]
            {
                new WordAppearance("", 1),
            };
        }
    }
}
