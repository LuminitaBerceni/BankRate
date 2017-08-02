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

        [TestMethod]
        public void SortTextWithFourWords()
        {
            var result = new WordAppearance[]
            {
                new WordAppearance("mere", 2),
                new WordAppearance("pere", 1),
                new WordAppearance("si", 1),
                new WordAppearance("iar", 1)
            };
            CollectionAssert.AreEqual(result, FindAndSortWordsByAppearances("pere mere si iar mere"));
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
            WordAppearance[] result = new WordAppearance[0];
            string[] words = text.Split(' ');
            string[] temporarArray = new string[0];
            while (words.Length > 0)
            {
                int count = 1;
                for (int i = 1; i < words.Length; i++)
                {
                    if (words[0] == words[i])
                        count++;
                    else
                    {
                        Array.Resize(ref temporarArray, temporarArray.Length + 1);
                        temporarArray[temporarArray.Length - 1] = words[i];
                    }
                }
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = new WordAppearance(words[0], count);
                words = temporarArray;
                temporarArray = new string[0];
            }
            SortWords(ref result);
            return result;
        }

        private void SortWords(ref WordAppearance[] result)
        {
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i].appearances < result[j].appearances)
                    {
                        WordAppearance temporar = result[i];
                        result[i] = result[j];
                        result[j] = temporar;
                    }
                }
            }
        }
    }
}
