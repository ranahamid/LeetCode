using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _151
    {
        public string ReverseWords_12(string s)
        {
            var sb = new List<string>();
            foreach (var item in s.Split(' ', options: StringSplitOptions.RemoveEmptyEntries).Reverse())
                sb.Add(item);
            return String.Join(' ', sb);
        }
        public string ReverseWords_11(string s)
        {
            var left = 0;
            var right = s.Length - 1;
            while (left < right && s[left] == ' ')
            {
                left++;
            }
            while (left < right && s[right] == ' ')
            {
                right--;
            }
            var stack = new Stack<string>();
            var word = new StringBuilder();
            for (var i = left; i <= right; i++)
            {
                if (word.Length > 0 && s[i] == ' ')
                {
                    stack.Push(word.ToString());
                    word = new StringBuilder();
                }
                else if (s[i] != ' ')
                {
                    word.Append(s[i]);
                }
            }
            stack.Push(word.ToString());
            var result = new List<string>();
            int counter = stack.Count;
            for (int i = 0; i < counter; i++)
            {
                result.Add(stack.Pop());
            }
            return string.Join(" ", result);
        }
        /// <summary>
        /// Runtime 141 ms Beats 34.59% Memory 37.8 MB Beats 38.36%
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseWords_10(string s)
        {
            int left = 0;
            int right = s.Length - 1;
            while (left <= right && s[left] == ' ')
            {
                left++;
            }
            while (left <= right && s[right] == ' ')
            {
                right--;
            }
            var stack = new Stack<string>();
            var word = new StringBuilder();
            while (left <= right)
            {
                var ch = s[left];
                if (word.Length != 0 && ch == ' ')
                {
                    stack.Push(word.ToString());
                    word = new StringBuilder();
                }
                else if (ch != ' ')
                {
                    word.Append(ch.ToString());
                }
                left++;
            }
            stack.Push(word.ToString());

            int counter = stack.Count;
            var result = new List<string>();
            for (int i = 0; i < counter; i++)
            {
                result.Add(stack.Pop());
            }
            return string.Join(" ", result);
        }
        /// <summary>
        /// Runtime 88 ms Beats 88.87% Memory 38.5 MB Beats 14.55%
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseWords_2(string s)
        {
            var words = s.Split(' ');
            var result = new List<string>();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    result.Add(words[i]);
                }
            }
            return string.Join(' ', result);
        }
        /// <summary>
        /// Runtime: 90 ms, faster than 86.35% of C# online submissions for Reverse Words in a String.
        /// Memory Usage: 39 MB, less than 7.70% of C# online submissions for Reverse Words in a String.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string ReverseWords_1(string s)
        {
            s = s.Trim();
            var words = s.Split(' ');

            var lsit = words.Reverse().ToArray();
            var result = new List<string>();
            foreach (var word in lsit)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    result.Add(word.Trim());
                }
            }
            var sentence = string.Join(" ", result);
            return sentence;
        }
    }
}
