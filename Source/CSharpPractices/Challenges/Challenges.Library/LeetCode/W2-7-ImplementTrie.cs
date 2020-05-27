using Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.Library.LeetCode
{
    public class ImplementTrie
    {
        /*
         Implement Trie (Prefix Tree)

        Trie trie = new Trie();

        trie.insert("apple");
        trie.search("apple");   // returns true
        trie.search("app");     // returns false
        trie.startsWith("app"); // returns true
        trie.insert("app");   
        trie.search("app");     // returns true

        Note:

        You may assume that all inputs are consist of lowercase letters a-z.
        All inputs are guaranteed to be non-empty strings.

        
        
         * Your Trie object will be instantiated and called as such:
         * Trie obj = new Trie();
         * obj.Insert(word);
         * bool param_2 = obj.Search(word);
         * bool param_3 = obj.StartsWith(prefix);
         

         */

        public static void Run()
        {
            Base.Start(typeof(ImplementTrie));


            PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                {nameof(Trie_LeetCodeBest),   ()=>{ CheckTrie(new Trie_LeetCodeBest()); } },
                //{nameof(Trie_TrieNodeArray),   ()=>{ CheckTrie(new Trie_TrieNodeArray()); } },
                {nameof(Trie_TrieNodeDictionary),   ()=>{ CheckTrie(new Trie_TrieNodeDictionary()); } },
                {nameof(Trie_SortedSet),   ()=>{ CheckTrie(new Trie_SortedSet()); } },
                //{nameof(Trie_Dictionary),   ()=>{ CheckTrie(new Trie_Dictionary()); } },
                //{nameof(Trie_List),   ()=>{ CheckTrie(new Trie_List()); } },
            });

            Base.End(typeof(ImplementTrie));
        }

        public static void CheckTrie(ITrie trie)
        {
            string[] commands = new string[] { "insert", "insert", "insert", "insert", "insert", "insert", "search", "search", "search", "search", "search", "search", "search", "search", "search", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith", "startsWith" };
            string[] inputs = new string[] { "app", "apple", "beer", "add", "jam", "rental", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam", "apps", "app", "ad", "applepie", "rest", "jan", "rent", "beer", "jam" };
            //bool?[] expectedResults = new bool?[] { null, null, null, null, null, null, false, true, false, false, false, false, false, true, true, false, true, true, false, false, false, true, true, true };

            for (int j = 0; j < 50; j++)
            {

                for (int i = 0; i < commands.Length; i++)
                {
                    switch (commands[i])
                    {
                        case "insert":
                            trie.Insert(inputs[i] + j.ToString());
                            break;

                        case "search":
                            _ = trie.Search(inputs[i] + j.ToString());
                            break;

                        case "startsWith":
                            _ = trie.StartsWith(inputs[i] + j.ToString());
                            break;

                        default:
                            break;
                    }

                }

            }


        }


        public interface ITrie
        {
            void Insert(string word);
            bool Search(string word);
            bool StartsWith(string prefix);
        }

        public class Node
        {
            public char key;
            public bool isWord;

            public Node left;
            public Node right;
            public Node middle;

            public Node(char key)
            {
                this.key = key;
            }
        }

        public class Trie_LeetCodeBest : ITrie
        {
            Node root;

            /** Initialize your data structure here. */
            public Trie_LeetCodeBest()
            {
            }

            /** Inserts a word into the trie. */
            public void Insert(string word)
            {
                if (word.Length > 0)
                {
                    root = insert(root, word, 0);
                }
            }

            private Node insert(Node node, string word, int d)
            {
                char c = word[d];
                if (node == null)
                {
                    node = new Node(c);
                }

                if (c > node.key)
                {
                    node.right = insert(node.right, word, d);
                }
                else if (c < node.key)
                {
                    node.left = insert(node.left, word, d);
                }
                else if (c == node.key)
                {
                    if (d < word.Length - 1)
                    {
                        node.middle = insert(node.middle, word, d + 1);
                    }
                    else
                    {
                        node.isWord = true;
                    }
                }

                return node;
            }

            /** Returns if the word is in the trie. */
            public bool Search(string word)
            {
                if (string.IsNullOrEmpty(word))
                {
                    return false;
                }

                var node = search(root, word, 0);
                return node != null && node.isWord;
            }

            private Node search(Node node, string word, int d)
            {
                if (node == null) { return node; }

                char c = word[d];

                if (c > node.key)
                {
                    node = search(node.right, word, d);
                }
                else if (c < node.key)
                {
                    node = search(node.left, word, d);
                }
                else if (d < word.Length - 1)
                {
                    node = search(node.middle, word, ++d);
                }

                return node;
            }

            /** Returns if there is any word in the trie that starts with the given prefix. */
            public bool StartsWith(string prefix)
            {
                if (string.IsNullOrEmpty(prefix))
                {
                    return false;
                }

                var node = search(root, prefix, 0);
                return node != null;
            }
        }

        internal class TrieNodeArray
        {
            internal TrieNodeArray[] arr;
            internal bool isEnd;

            public TrieNodeArray()
            {
                this.arr = new TrieNodeArray[26];
            }

        }

        public class Trie_TrieNodeArray : ITrie
        {
            private TrieNodeArray root;

            public Trie_TrieNodeArray()
            {
                root = new TrieNodeArray();
            }

            public void Insert(string word)
            {
                TrieNodeArray p = root;
                for (int i = 0; i < word.Length; i++)
                {
                    char c = word[i];
                    int index = c - 'a';
                    if (p.arr[index] == null)
                    {
                        TrieNodeArray temp = new TrieNodeArray();
                        p.arr[index] = temp;
                        p = temp;
                    }
                    else
                    {
                        p = p.arr[index];
                    }
                }
                p.isEnd = true;
            }


            public bool Search(string word)
            {
                TrieNodeArray p = searchNode(word);
                if (p == null)
                {
                    return false;
                }
                else
                {
                    if (p.isEnd)
                        return true;
                }

                return false;
            }


            public bool StartsWith(string prefix)
            {
                TrieNodeArray p = searchNode(prefix);
                if (p == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            private TrieNodeArray searchNode(string s)
            {
                TrieNodeArray p = root;
                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    int index = c - 'a';
                    if (p.arr[index] != null)
                    {
                        p = p.arr[index];
                    }
                    else
                    {
                        return null;
                    }
                }

                if (p == root)
                    return null;

                return p;
            }
        }


        internal class TrieNodeDictionary
        {
            char c;
            internal Dictionary<char, TrieNodeDictionary> children = new Dictionary<char, TrieNodeDictionary>();
            internal bool isLeaf;

            public TrieNodeDictionary() { }

            public TrieNodeDictionary(char c)
            {
                this.c = c;
            }
        }


        public class Trie_TrieNodeDictionary : ITrie
        {
            private TrieNodeDictionary root;

            public Trie_TrieNodeDictionary()
            {
                root = new TrieNodeDictionary();
            }

            // Inserts a word into the trie.
            public void Insert(String word)
            {
                Dictionary<char, TrieNodeDictionary> children = root.children;

                for (int i = 0; i < word.Length; i++)
                {
                    char c = word[i];

                    TrieNodeDictionary t;
                    if (children.ContainsKey(c))
                    {
                        t = children[c];
                    }
                    else
                    {
                        t = new TrieNodeDictionary(c);
                        children.Add(c, t);
                    }

                    children = t.children;

                    //set leaf node
                    if (i == word.Length - 1)
                        t.isLeaf = true;
                }
            }

            // Returns if the word is in the trie.
            public bool Search(string word)
            {
                TrieNodeDictionary t = searchNode(word);

                if (t != null && t.isLeaf)
                    return true;
                else
                    return false;
            }

            // Returns if there is any word in the trie
            // that starts with the given prefix.
            public bool StartsWith(string prefix)
            {
                if (searchNode(prefix) == null)
                    return false;
                else
                    return true;
            }

            internal TrieNodeDictionary searchNode(string str)
            {
                Dictionary<char, TrieNodeDictionary> children = root.children;
                TrieNodeDictionary t = null;
                for (int i = 0; i < str.Length; i++)
                {
                    char c = str[i];
                    if (children.ContainsKey(c))
                    {
                        t = children[c];
                        children = t.children;
                    }
                    else
                    {
                        return null;
                    }
                }

                return t;
            }
        }


        public class Trie_SortedSet : ITrie
        {
            SortedSet<string> items;

            public Trie_SortedSet()
            {
                items = new SortedSet<string>();
            }

            public void Insert(string word)
            {
                if (!items.Contains(word))
                    items.Add(word);
            }

            public bool Search(string word)
            {
                return items.Contains(word);
            }

            public bool StartsWith(string prefix)
            {
                return items.Any(x => x.StartsWith(prefix));
            }

        }


        public class Trie_Dictionary : ITrie
        {
            Dictionary<string, bool> items = new Dictionary<string, bool>();

            /** Initialize your data structure here. */
            public Trie_Dictionary()
            {
            }

            /** Inserts a word into the trie. */
            public void Insert(string word)
            {
                if (!items.ContainsKey(word))
                    items.Add(word, true);
            }

            /** Returns if the word is in the trie. */
            public bool Search(string word)
            {
                return items.ContainsKey(word);
            }

            /** Returns if there is any word in the trie that starts with the given prefix. */
            public bool StartsWith(string prefix)
            {
                return items.Keys.Any(x => x.StartsWith(prefix));
            }

        }


        public class Trie_List : ITrie
        {
            private List<string> itemList;
            private string[] items;
            private int currentIndex = -1;

            /** Initialize your data structure here. */
            public Trie_List()
            {
                itemList = new List<string>();
            }

            /** Inserts a word into the trie. */
            public void Insert(string word)
            {
                if (currentIndex > -1 && Search(word))
                    return;

                currentIndex++;

                itemList.Add(word);
                items = itemList.ToArray();
                Array.Sort(items);
                itemList = items.ToList();
            }

            /** Returns if the word is in the trie. */
            public bool Search(string word)
            {
                if (currentIndex == -1)
                    return false;

                int index = Array.BinarySearch(items, word);
                return index >= 0;
            }

            /** Returns if there is any word in the trie that starts with the given prefix. */
            public bool StartsWith(string prefix)
            {
                if (currentIndex == -1)
                    return false;
                int index = BinarySearchStartWith(prefix);

                return index >= 0;
            }

            private int BinarySearchStartWith(string searchValue)
            {
                if (currentIndex == 0)
                    return items[0].StartsWith(searchValue) ? 0 : -1;

                int startIndex = 0;
                int endIndex = currentIndex;

                while (startIndex <= endIndex)
                {
                    int midIndex = (startIndex + endIndex) / 2;

                    if (items[midIndex].StartsWith(searchValue) || items[midIndex] == searchValue)
                        return midIndex;

                    if (PrefixSmallerThan(searchValue, items[midIndex]))
                        endIndex = midIndex - 1;

                    else
                        startIndex = midIndex + 1;

                }

                return -1;
            }

            private bool PrefixSmallerThan(string searchValue, string item)
            {

                int length = item.Length < searchValue.Length ? item.Length : searchValue.Length;

                for (int i = 0; i < length; i++)
                {
                    if (searchValue[i] == item[i])
                        continue;

                    if (searchValue[i] < item[i])
                        return true;
                    else
                        return false;
                }

                return false;
            }

        }

    }
}
