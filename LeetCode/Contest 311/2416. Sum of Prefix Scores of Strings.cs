using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_311
{
    internal class _2416
    {
        /// <summary>
        /// Runtime: 1220 ms, faster than 100.00% of C# online submissions for Sum of Prefix Scores of Strings.
        /// Memory Usage: 255.1 MB, less than 100.00% of C# online submissions for Sum of Prefix Scores of Strings.
        /// </summary>
        public class TrieNode
        {
            public TrieNode[] children;
            public bool isSuccess;
            public int prefixCount = 0;
            public TrieNode()
            {
                children = new TrieNode[26];
                isSuccess = false;
            }
        }
        TrieNode root = new TrieNode();
        public int[] SumPrefixScores(string[] words)
        {
            var result = new int[words.Length];
            var index = 0;
            root = new TrieNode();
            foreach (var word in words)
                Insert(word);
            foreach (String word in words)
            {
                result[index++] = CountPrefix(word);
            }
            return result;
        }
        public void Insert(String word)
        {
            TrieNode trieNode = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (trieNode.children[word[i] - 97] == null)
                    trieNode.children[word[i] - 97] = new TrieNode();

                trieNode = trieNode.children[word[i] - 97];
                trieNode.prefixCount++;
            }
            trieNode.isSuccess = true;
        }
        public int CountPrefix(String prefix)
        {
            TrieNode trieNode = root;
            int counterSum = 0;
            for (int i = 0; i < prefix.Length; i++)
            {
                if (trieNode.children[prefix[i] - 97] == null)
                    break;
                trieNode = trieNode.children[prefix[i] - 97];
                counterSum += trieNode.prefixCount;
            }
            return counterSum;
        }
    }
}
