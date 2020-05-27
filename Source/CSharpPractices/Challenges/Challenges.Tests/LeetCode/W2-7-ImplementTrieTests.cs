using Xunit;

namespace Challenges.Tests.LeetCode
{
    public class ImplementTrieTests
    {
        [Fact]
        public void ValidImplementTrie_List()
        {
            Library.LeetCode.ImplementTrie.Trie_List trie = new Library.LeetCode.ImplementTrie.Trie_List();

            trie.Insert("mamamia");
            trie.Insert("gooogolia");

            bool result1 = trie.Search("shooshoo");
            Assert.True(result1 == false, $"{nameof(Library.LeetCode.ImplementTrie.Trie_List)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{result1}' but expected is '{false}' for: 'shooshoo'");


            bool result2 = trie.Search("mamamia");
            Assert.True(result2 == true, $"{nameof(Library.LeetCode.ImplementTrie.Trie_List)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{result2}' but expected is '{true}' for: 'mamamia'");


            bool result3 = trie.Search("gooogolia");
            Assert.True(result3 == true, $"{nameof(Library.LeetCode.ImplementTrie.Trie_List)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{result3}' but expected is '{true}' for: 'gooogolia'");


            bool result4 = trie.StartsWith("jui");
            Assert.True(result4 == false, $"{nameof(Library.LeetCode.ImplementTrie.Trie_List)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{result4}' but expected is '{false}' for: 'jui'");


            bool result5 = trie.StartsWith("goo");
            Assert.True(result5 == true, $"{nameof(Library.LeetCode.ImplementTrie.Trie_List)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{result5}' but expected is '{true}' for: 'goo'");


            bool result6 = trie.StartsWith("ma");
            Assert.True(result6 == true, $"{nameof(Library.LeetCode.ImplementTrie.Trie_List)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{result6}' but expected is '{true}' for: 'ma'");

        }

        [Fact]
        public void ValidImplementTrie_ListArrayCommands()
        {
            string[] commands = new string[] { "insert", "search", "search", "startsWith", "startsWith", "insert", "search", "startsWith", "insert", "search", "startsWith" };
            string[] inputs = new string[] { "ab", "abc", "ab", "abc", "ab", "ab", "abc", "abc", "abc", "abc", "abc" };
            bool?[] expectedResults = new bool?[] { null, false, true, false, true, null, false, false, null, true, true };

            Library.LeetCode.ImplementTrie.Trie_List trie = new Library.LeetCode.ImplementTrie.Trie_List();

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "insert":
                        trie.Insert(inputs[i]);
                        break;

                    case "search":
                        var searchResult = trie.Search(inputs[i]);
                        Assert.True(searchResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_List)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{searchResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'");
                        break;

                    case "startsWith":
                        var startWithResult = trie.StartsWith(inputs[i]);
                        Assert.True(startWithResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_List)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{startWithResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'");
                        break;

                    default:
                        break;
                }

            }


        }

        [Fact]
        public void ValidImplementTrie_ListArrayCommandsII()
        {
            string[] commands = new string[] { "insert", "insert", "insert", "insert", "insert", "insert", "search", "search", "search", "search", "search", "search", "search", "search", "search", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith" };
            string[] inputs = new string[] { "app", "apple", "beer", "add", "jam", "rental", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam" };
            bool?[] expectedResults = new bool?[] { null, null, null, null, null, null, false, true, false, false, false, false, false, true, true, false, true, true, false, false, false, true, true, true };

            Library.LeetCode.ImplementTrie.Trie_List trie = new Library.LeetCode.ImplementTrie.Trie_List();

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "insert":
                        trie.Insert(inputs[i]);
                        break;

                    case "search":
                        var searchResult = trie.Search(inputs[i]);
                        Assert.True(searchResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_List)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{searchResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'({i + 1})");
                        break;

                    case "startsWith":
                        var startWithResult = trie.StartsWith(inputs[i]);
                        Assert.True(startWithResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_List)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{startWithResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'({i + 1})");
                        break;

                    default:
                        break;
                }

            }


        }

        [Fact]
        public void ValidImplementTrie_Dictionary()
        {
            Library.LeetCode.ImplementTrie.Trie_Dictionary trie = new Library.LeetCode.ImplementTrie.Trie_Dictionary();

            trie.Insert("mamamia");
            trie.Insert("gooogolia");

            bool result1 = trie.Search("shooshoo");
            Assert.True(result1 == false, $"{nameof(Library.LeetCode.ImplementTrie.Trie_Dictionary)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{result1}' but expected is '{false}' for: 'shooshoo'");


            bool result2 = trie.Search("mamamia");
            Assert.True(result2 == true, $"{nameof(Library.LeetCode.ImplementTrie.Trie_Dictionary)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{result2}' but expected is '{true}' for: 'mamamia'");


            bool result3 = trie.Search("gooogolia");
            Assert.True(result3 == true, $"{nameof(Library.LeetCode.ImplementTrie.Trie_Dictionary)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{result3}' but expected is '{true}' for: 'gooogolia'");


            bool result4 = trie.StartsWith("jui");
            Assert.True(result4 == false, $"{nameof(Library.LeetCode.ImplementTrie.Trie_Dictionary)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{result4}' but expected is '{false}' for: 'jui'");


            bool result5 = trie.StartsWith("goo");
            Assert.True(result5 == true, $"{nameof(Library.LeetCode.ImplementTrie.Trie_Dictionary)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{result5}' but expected is '{true}' for: 'goo'");


            bool result6 = trie.StartsWith("ma");
            Assert.True(result6 == true, $"{nameof(Library.LeetCode.ImplementTrie.Trie_Dictionary)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{result6}' but expected is '{true}' for: 'ma'");

        }

        [Fact]
        public void ValidImplementTrie_DictionaryArrayCommands()
        {
            string[] commands = new string[] { "insert", "search", "search", "startsWith", "startsWith", "insert", "search", "startsWith", "insert", "search", "startsWith" };
            string[] inputs = new string[] { "ab", "abc", "ab", "abc", "ab", "ab", "abc", "abc", "abc", "abc", "abc" };
            bool?[] expectedResults = new bool?[] { null, false, true, false, true, null, false, false, null, true, true };

            Library.LeetCode.ImplementTrie.Trie_Dictionary trie = new Library.LeetCode.ImplementTrie.Trie_Dictionary();

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "insert":
                        trie.Insert(inputs[i]);
                        break;

                    case "search":
                        var searchResult = trie.Search(inputs[i]);
                        Assert.True(searchResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_Dictionary)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{searchResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'");
                        break;

                    case "startsWith":
                        var startWithResult = trie.StartsWith(inputs[i]);
                        Assert.True(startWithResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_Dictionary)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{startWithResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'");
                        break;

                    default:
                        break;
                }

            }


        }

        [Fact]
        public void ValidImplementTrie_DictionaryArrayCommandsII()
        {
            string[] commands = new string[] { "insert", "insert", "insert", "insert", "insert", "insert", "search", "search", "search", "search", "search", "search", "search", "search", "search", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith" };
            string[] inputs = new string[] { "app", "apple", "beer", "add", "jam", "rental", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam" };
            bool?[] expectedResults = new bool?[] { null, null, null, null, null, null, false, true, false, false, false, false, false, true, true, false, true, true, false, false, false, true, true, true };

            Library.LeetCode.ImplementTrie.Trie_Dictionary trie = new Library.LeetCode.ImplementTrie.Trie_Dictionary();

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "insert":
                        trie.Insert(inputs[i]);
                        break;

                    case "search":
                        var searchResult = trie.Search(inputs[i]);
                        Assert.True(searchResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_Dictionary)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{searchResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'({i + 1})");
                        break;

                    case "startsWith":
                        var startWithResult = trie.StartsWith(inputs[i]);
                        Assert.True(startWithResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_Dictionary)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{startWithResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'({i + 1})");
                        break;

                    default:
                        break;
                }

            }


        }

        [Fact]
        public void ValidImplementTrie_SortedSet()
        {
            Library.LeetCode.ImplementTrie.Trie_SortedSet trie = new Library.LeetCode.ImplementTrie.Trie_SortedSet();

            trie.Insert("mamamia");
            trie.Insert("gooogolia");

            bool result1 = trie.Search("shooshoo");
            Assert.True(result1 == false, $"{nameof(Library.LeetCode.ImplementTrie.Trie_SortedSet)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{result1}' but expected is '{false}' for: 'shooshoo'");


            bool result2 = trie.Search("mamamia");
            Assert.True(result2 == true, $"{nameof(Library.LeetCode.ImplementTrie.Trie_SortedSet)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{result2}' but expected is '{true}' for: 'mamamia'");


            bool result3 = trie.Search("gooogolia");
            Assert.True(result3 == true, $"{nameof(Library.LeetCode.ImplementTrie.Trie_SortedSet)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{result3}' but expected is '{true}' for: 'gooogolia'");


            bool result4 = trie.StartsWith("jui");
            Assert.True(result4 == false, $"{nameof(Library.LeetCode.ImplementTrie.Trie_SortedSet)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{result4}' but expected is '{false}' for: 'jui'");


            bool result5 = trie.StartsWith("goo");
            Assert.True(result5 == true, $"{nameof(Library.LeetCode.ImplementTrie.Trie_SortedSet)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{result5}' but expected is '{true}' for: 'goo'");


            bool result6 = trie.StartsWith("ma");
            Assert.True(result6 == true, $"{nameof(Library.LeetCode.ImplementTrie.Trie_SortedSet)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{result6}' but expected is '{true}' for: 'ma'");

        }

        [Fact]
        public void ValidImplementTrie_SortedSetArrayCommands()
        {
            string[] commands = new string[] { "insert", "search", "search", "startsWith", "startsWith", "insert", "search", "startsWith", "insert", "search", "startsWith" };
            string[] inputs = new string[] { "ab", "abc", "ab", "abc", "ab", "ab", "abc", "abc", "abc", "abc", "abc" };
            bool?[] expectedResults = new bool?[] { null, false, true, false, true, null, false, false, null, true, true };

            Library.LeetCode.ImplementTrie.Trie_SortedSet trie = new Library.LeetCode.ImplementTrie.Trie_SortedSet();

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "insert":
                        trie.Insert(inputs[i]);
                        break;

                    case "search":
                        var searchResult = trie.Search(inputs[i]);
                        Assert.True(searchResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_SortedSet)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{searchResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'");
                        break;

                    case "startsWith":
                        var startWithResult = trie.StartsWith(inputs[i]);
                        Assert.True(startWithResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_SortedSet)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{startWithResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'");
                        break;

                    default:
                        break;
                }

            }


        }

        [Fact]
        public void ValidImplementTrie_SortedSetArrayCommandsII()
        {
            string[] commands = new string[] { "insert", "insert", "insert", "insert", "insert", "insert", "search", "search", "search", "search", "search", "search", "search", "search", "search", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith" };
            string[] inputs = new string[] { "app", "apple", "beer", "add", "jam", "rental", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam" };
            bool?[] expectedResults = new bool?[] { null, null, null, null, null, null, false, true, false, false, false, false, false, true, true, false, true, true, false, false, false, true, true, true };

            Library.LeetCode.ImplementTrie.Trie_SortedSet trie = new Library.LeetCode.ImplementTrie.Trie_SortedSet();

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "insert":
                        trie.Insert(inputs[i]);
                        break;

                    case "search":
                        var searchResult = trie.Search(inputs[i]);
                        Assert.True(searchResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_SortedSet)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{searchResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'({i + 1})");
                        break;

                    case "startsWith":
                        var startWithResult = trie.StartsWith(inputs[i]);
                        Assert.True(startWithResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_SortedSet)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{startWithResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'({i + 1})");
                        break;

                    default:
                        break;
                }

            }


        }


        [Fact]
        public void ValidImplementTrie_TriNodeDictionaryArrayCommandsII()
        {
            string[] commands = new string[] { "insert", "insert", "insert", "insert", "insert", "insert", "search", "search", "search", "search", "search", "search", "search", "search", "search", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith" };
            string[] inputs = new string[] { "app", "apple", "beer", "add", "jam", "rental", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam" };
            bool?[] expectedResults = new bool?[] { null, null, null, null, null, null, false, true, false, false, false, false, false, true, true, false, true, true, false, false, false, true, true, true };

            Library.LeetCode.ImplementTrie.Trie_TrieNodeDictionary trie = new Library.LeetCode.ImplementTrie.Trie_TrieNodeDictionary();

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "insert":
                        trie.Insert(inputs[i]);
                        break;

                    case "search":
                        var searchResult = trie.Search(inputs[i]);
                        Assert.True(searchResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_TrieNodeDictionary)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{searchResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'({i + 1})");
                        break;

                    case "startsWith":
                        var startWithResult = trie.StartsWith(inputs[i]);
                        Assert.True(startWithResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_TrieNodeDictionary)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{startWithResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'({i + 1})");
                        break;

                    default:
                        break;
                }

            }


        }


        [Fact]
        public void ValidImplementTrie_TrieNodeArrayArrayCommandsII()
        {
            string[] commands = new string[] { "insert", "insert", "insert", "insert", "insert", "insert", "search", "search", "search", "search", "search", "search", "search", "search", "search", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith" };
            string[] inputs = new string[] { "app", "apple", "beer", "add", "jam", "rental", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam" };
            bool?[] expectedResults = new bool?[] { null, null, null, null, null, null, false, true, false, false, false, false, false, true, true, false, true, true, false, false, false, true, true, true };

            Library.LeetCode.ImplementTrie.Trie_TrieNodeArray trie = new Library.LeetCode.ImplementTrie.Trie_TrieNodeArray();

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "insert":
                        trie.Insert(inputs[i]);
                        break;

                    case "search":
                        var searchResult = trie.Search(inputs[i]);
                        Assert.True(searchResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_TrieNodeArray)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{searchResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'({i + 1})");
                        break;

                    case "startsWith":
                        var startWithResult = trie.StartsWith(inputs[i]);
                        Assert.True(startWithResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_TrieNodeArray)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{startWithResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'({i + 1})");
                        break;

                    default:
                        break;
                }

            }


        }

        [Fact]
        public void ValidImplementTrie_LeetCodeBestArrayCommandsII()
        {
            string[] commands = new string[] { "insert", "insert", "insert", "insert", "insert", "insert", "search", "search", "search", "search", "search", "search", "search", "search", "search", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith" };
            string[] inputs = new string[] { "app", "apple", "beer", "add", "jam", "rental", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam" };
            bool?[] expectedResults = new bool?[] { null, null, null, null, null, null, false, true, false, false, false, false, false, true, true, false, true, true, false, false, false, true, true, true };

            Library.LeetCode.ImplementTrie.Trie_LeetCodeBest trie = new Library.LeetCode.ImplementTrie.Trie_LeetCodeBest();

            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "insert":
                        trie.Insert(inputs[i]);
                        break;

                    case "search":
                        var searchResult = trie.Search(inputs[i]);
                        Assert.True(searchResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_LeetCodeBest)} ({nameof(trie.Search)}) does not meet the expected. Solution result is '{searchResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'({i + 1})");
                        break;

                    case "startsWith":
                        var startWithResult = trie.StartsWith(inputs[i]);
                        Assert.True(startWithResult == expectedResults[i], $"{nameof(Library.LeetCode.ImplementTrie.Trie_LeetCodeBest)} ({nameof(trie.StartsWith)}) does not meet the expected. Solution result is '{startWithResult}' but expected is '{expectedResults[i]}' for: '{inputs[i]}'({i + 1})");
                        break;

                    default:
                        break;
                }

            }


        }



    }
}
