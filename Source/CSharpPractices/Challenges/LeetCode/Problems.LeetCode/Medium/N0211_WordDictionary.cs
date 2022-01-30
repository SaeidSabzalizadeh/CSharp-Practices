using System.Collections.Generic;
using System.Collections.Specialized;

namespace Problems.LeetCode.Medium
{

    /// <summary>
    /// Design Add and Search Words Data Structure
    /// 
    /// Design a data structure that supports adding new words and finding if a string matches any previously added string.
    /// 
    /// Implement the WordDictionary class:
    /// WordDictionary() Initializes the object.
    /// void addWord(word) Adds word to the data structure, it can be matched later.
    /// bool search(word) Returns true if there is any string in the data structure that matches word or false otherwise.word may contain dots '.' where dots can be matched with any letter.
    /// 
    /// Example:
    /// 
    /// Input
    /// ["WordDictionary","addWord","addWord","addWord","search","search","search","search"]
    /// [[],["bad"],["dad"],["mad"],["pad"],["bad"],[".ad"],["b.."]]
    /// 
    /// Output
    /// [null, null, null, null, false, true, true, true]
    /// 
    /// Explanation
    /// WordDictionary wordDictionary = new WordDictionary();
    /// wordDictionary.addWord("bad");
    /// wordDictionary.addWord("dad");
    /// wordDictionary.addWord("mad");
    /// wordDictionary.search("pad"); // return False
    /// wordDictionary.search("bad"); // return True
    /// wordDictionary.search(".ad"); // return True
    /// wordDictionary.search("b.."); // return True
    /// 
    /// 
    /// Constraints:
    /// 1 <= word.length <= 500
    /// word in addWord consists lower-case English letters.
    /// word in search consist of  '.' or lower-case English letters.
    /// At most 50000 calls will be made to addWord and search.
    /// 
    /// 
    /// https://leetcode.com/problems/design-add-and-search-words-data-structure/
    /// </summary>
    public class N0211_WordDictionary
    {
        public interface IN0211Dictionary
        {
            void AddWord(string word);
            bool Search(string word);

        }


        public class WordDictionaryByDictionary : IN0211Dictionary
        {
            private readonly Dictionary<int, List<string>> _dictionary;

            public WordDictionaryByDictionary()
            {
                _dictionary = new Dictionary<int, List<string>>();
            }

            public void AddWord(string word)
            {
                if (Search(word))
                    return;

                if (!_dictionary.ContainsKey(word.Length))
                    _dictionary.Add(word.Length, new List<string>());

                _dictionary[word.Length].Add(word);
            }

            public bool Search(string word)
            {
                if (!_dictionary.ContainsKey(word.Length))
                    return false;

                for (int i = 0; i < _dictionary[word.Length].Count; i++)
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (word[j] != '.')
                        {
                            if (word[j] != _dictionary[word.Length][i][j])
                                break;
                        }

                        if (j == word.Length - 1)
                            return true;
                    }
                }

                return false;

            }
        }

        public class WordDictionaryBySimpleArray : IN0211Dictionary
        {
            private readonly string[] _dictionary;
            int _index = -1;

            public WordDictionaryBySimpleArray()
            {
                _dictionary = new string[50000];
            }

            public void AddWord(string word)
            {
                if (Search(word))
                    return;

                _index++;
                _dictionary[_index] = word;
            }

            public bool Search(string word)
            {
                if (_index < 0)
                    return false;

                for (int i = 0; i <= _index; i++)
                {
                    if (_dictionary[i].Length == word.Length)
                    {
                        for (int j = 0; j < word.Length; j++)
                        {
                            if (word[j] != '.')
                            {
                                if (word[j] != _dictionary[i][j])
                                    break;
                            }

                            if (j == word.Length - 1)
                                return true;
                        }
                    }
                }

                return false;

            }
        }


        public class WordDictionaryByTri : IN0211Dictionary
        {
            private readonly Trie _trie;

            public WordDictionaryByTri()
            {
                _trie = new Trie();
            }

            public void AddWord(string word)
            {
                if (!Search(word))
                    _trie.Insert(word);

            }

            public bool Search(string word)
            {
                return _trie.Search(word);

            }
        }


        public class WordDictionaryBestSolution : IN0211Dictionary
        {
            private Dictionary<int, HashSet<string>> dict;

            public WordDictionaryBestSolution()
            {
                dict = new Dictionary<int, HashSet<string>>();
            }

            public void AddWord(string word)
            {
                HashSet<string> match;
                if (dict.TryGetValue(word.Length, out match))
                {
                    match.Add(word);
                }
                else
                {
                    dict.Add(word.Length, new HashSet<string>() { word });
                }
            }

            public bool Search(string word)
            {
                HashSet<string> match;
                if (!dict.TryGetValue(word.Length, out match))
                {
                    return false;
                }

                foreach (var w in match)
                {
                    bool eq = true;
                    for (int i = 0; i < w.Length; i++)
                    {
                        if (word[i] != w[i] && word[i] != '.')
                        {
                            eq = false;
                            break;
                        }
                    }

                    if (eq)
                    {
                        return true;
                    }
                }
                return false;
            }



        }

    }


    public class Trie
    {
        private TrieNode _root;

        public Trie()
        {
            _root = new TrieNode(' ');
        }



        public bool Search(string word)
        {
            if (word.Length == 0)
                return false;

            if (_root == null)
                return false;

            if (word[0] == '.')
            {
                for (int i = 0; i < 26; i++)
                {
                    if (Search(_root.Childrens[i], word, 0))
                        return true;
                }

                return false;
            }
            else
            {
                return Search(_root.Childrens[word[0] - 'a'], word, 0);
            }
        }

        private bool Search(TrieNode node, string word, int index)
        {
            if (node == null)
                return false;

            if (index == word.Length - 1)
                return node.IsWord;

            if (node.Childrens == null)
                return false;

            if (word[index + 1] == '.')
            {
                for (int i = 0; i < 26; i++)
                {
                    if (Search(node.Childrens[i], word, index + 1))
                        return true;
                }

                return false;
            }
            else
            {
                return Search(node.Childrens[word[index + 1] - 'a'], word, index + 1);
            }
        }


        public void Insert(string word)
        {
            if (word.Length > 0)
                _root.Childrens[word[0] - 'a'] = Insert(_root.Childrens[word[0] - 'a'], word, 0);
        }

        private TrieNode Insert(TrieNode node, string word, int index)
        {
            if (node == null)
                node = new TrieNode(word[index]);

            if (index == word.Length - 1)
            {
                node.IsWord = true;
                return node;
            }

            node.Childrens[word[index + 1] - 'a'] = Insert(node.Childrens[word[index + 1] - 'a'], word, index + 1);

            return node;

        }


    }

    public class TrieNode
    {
        public bool IsWord { get; set; }
        public char Key { get; set; }
        public TrieNode[] Childrens { get; set; }


        public TrieNode(char key)
        {
            Key = key;
            Childrens = new TrieNode[26];
        }
    }
}
