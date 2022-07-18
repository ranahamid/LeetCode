using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _17
    {
        /// <summary>
        /// Runtime: 187 ms, faster than 65.44% of C# online submissions for Letter Combinations of a Phone Number.
        /// Memory Usage: 42.2 MB, less than 82.05% of C# online submissions for Letter Combinations of a Phone Number.
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
                return new List<string>();
            var letters = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            var queues = new Queue<string>();
            queues.Enqueue("");
            foreach (var item in digits)
            {
                var count = queues.Count();
                while (count > 0)
                {
                    var queueItem = queues.Dequeue();
                    var combinations = letters[item - '0'];
                    foreach (var ch in combinations)
                    {
                        queues.Enqueue(queueItem + ch);
                    }
                    count--;
                }
            }
            return queues.ToList();
        }
    }
}
