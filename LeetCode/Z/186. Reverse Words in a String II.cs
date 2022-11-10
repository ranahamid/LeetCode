using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _186
    {
        #region in place
        public void ReverseWords(char[] s)
        {
            Reverse(s, 0, s.Length - 1);
            int n = s.Length;
            int start = 0, end = 0;
            while (start < n)
            {
                while (end < n && s[end] != ' ')
                    end++;
                Reverse(s, start, end - 1);

                start = end + 1;
                end++;
            }
        }
        public void Reverse(char[] s, int i, int j)
        {
            while (i < j)
            {
                (s[i], s[j]) = (s[j], s[i]);
                i++;
                j--;
            }
        }
        #endregion
        /// <summary>
        /// Runtime 463 ms Beats 61.29% Memory 47.3 MB Beats 50.54%
        /// </summary>
        /// <param name="s"></param>
        public void ReverseWords_NotInPlace(char[] s)
        {
            var result = new Stack<string>();
            var word = "";
            foreach (var item in s)
            {
                if (word.Length > 0 && item == ' ')
                {
                    result.Push(word);
                    word = "";
                }
                else if (item != ' ')
                {
                    word = word + item;
                }
            }
            result.Push(word);
            var len = result.Count();
            int k = 0;
            for (var i = 0; i < len; i++)
            {
                var w = result.Pop();
                for (int j = 0; j < w.Length; j++)
                    s[k++] = w[j];
                if (i != len - 1)
                    s[k++] = ' ';
            }
        }
    }
}
