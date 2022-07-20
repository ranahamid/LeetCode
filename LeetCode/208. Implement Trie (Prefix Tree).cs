using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.NOT_SUBMITTED
{ 
    public class Trie
    {
        List<string> words;
        public Trie()
        {
            words = new List<string>();
        }

        public void Insert(string word)
        {
            words.Add(word);
        }

        public bool Search(string word)
        {
            foreach (var w in words)
            {
                if (w == word)
                    return true;
            }
            return false;
        }

        public bool StartsWith(string prefix)
        {
            foreach (var word in words)
            {
                if (word.StartsWith(prefix))
                    return true;
            }
            return false;
        }
    }

    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */
}
