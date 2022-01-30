using Problems.LeetCode.Medium;
using Xunit;

namespace Problems.LeetCode.Tests.Medium
{
    public class N0211_WordDictionaryTests
    {
        private void Initialize(N0211_WordDictionary.IN0211Dictionary wordDictionary, int initializer)
        {
            switch (initializer)
            {
                case 1:
                    wordDictionary.AddWord("bad");
                    wordDictionary.AddWord("dad");
                    wordDictionary.AddWord("mad");
                    break;

                case 2:
                    wordDictionary.AddWord("a");
                    wordDictionary.AddWord("a");
                    break;

                default:
                    break;
            }
        }


        [Theory]
        [InlineData(1, "pad", false)]
        [InlineData(1, "bad", true)]
        [InlineData(1, ".ad", true)]
        [InlineData(1, "b..", true)]
        [InlineData(2, ".", true)]
        [InlineData(2, "a", true)]
        [InlineData(2, "aa", false)]
        [InlineData(2, ".a", false)]
        [InlineData(2, "a.", false)]
        public void WordDictionaryByDictionaryTests(int initializer, string word, bool expectedResult)
        {
            N0211_WordDictionary.WordDictionaryByDictionary wordDictionary = new N0211_WordDictionary.WordDictionaryByDictionary();
            Initialize(wordDictionary, initializer);

            bool result = wordDictionary.Search(word);
            Assert.True(expectedResult == result, $"Search is not as expected, Word: '{word}' | Expected: '{expectedResult}', Actual: '{result}'");
        }


        [Theory]
        [InlineData(1, "pad", false)]
        [InlineData(1, "bad", true)]
        [InlineData(1, ".ad", true)]
        [InlineData(1, "b..", true)]
        [InlineData(2, ".", true)]
        [InlineData(2, "a", true)]
        [InlineData(2, "aa", false)]
        [InlineData(2, ".a", false)]
        [InlineData(2, "a.", false)]
        public void WordDictionaryBySimpleArrayTests(int initializer, string word, bool expectedResult)
        {
            N0211_WordDictionary.WordDictionaryBySimpleArray wordDictionary = new N0211_WordDictionary.WordDictionaryBySimpleArray();
            Initialize(wordDictionary, initializer);

            bool result = wordDictionary.Search(word);
            Assert.True(expectedResult == result, $"Search is not as expected, Word: '{word}' | Expected: '{expectedResult}', Actual: '{result}'");
        }

        [Theory]
        [InlineData(1, "pad", false)]
        [InlineData(1, "bad", true)]
        [InlineData(1, ".ad", true)]
        [InlineData(1, "b..", true)]
        [InlineData(2, ".", true)]
        [InlineData(2, "a", true)]
        [InlineData(2, "aa", false)]
        [InlineData(2, ".a", false)]
        [InlineData(2, "a.", false)]
        public void WordDictionaryByTriTests(int initializer, string word, bool expectedResult)
        {
            N0211_WordDictionary.WordDictionaryByTri wordDictionary = new N0211_WordDictionary.WordDictionaryByTri();
            Initialize(wordDictionary, initializer);

            bool result = wordDictionary.Search(word);
            Assert.True(expectedResult == result, $"Search is not as expected, Word: '{word}' | Expected: '{expectedResult}', Actual: '{result}'");
        }


        [Theory]
        [InlineData(1, "pad", false)]
        [InlineData(1, "bad", true)]
        [InlineData(1, ".ad", true)]
        [InlineData(1, "b..", true)]
        [InlineData(2, ".", true)]
        [InlineData(2, "a", true)]
        [InlineData(2, "aa", false)]
        [InlineData(2, ".a", false)]
        [InlineData(2, "a.", false)]
        public void WordDictionaryBestSolutionTests(int initializer, string word, bool expectedResult)
        {
            N0211_WordDictionary.WordDictionaryBestSolution wordDictionary = new N0211_WordDictionary.WordDictionaryBestSolution();
            Initialize(wordDictionary, initializer);

            bool result = wordDictionary.Search(word);
            Assert.True(expectedResult == result, $"Search is not as expected, Word: '{word}' | Expected: '{expectedResult}', Actual: '{result}'");
        }

    }
}
