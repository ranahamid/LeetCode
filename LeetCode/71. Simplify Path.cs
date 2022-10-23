using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _71
    {
        /// <summary>
        /// Runtime 84 ms Beats 92.40% Memory 38.9 MB Beats 14.80%
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string SimplifyPath(string path)
        {
            var stack = new Stack<string>();
            var words = path.Split("/", StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {
                if (item == ".")
                    continue;
                if (item == "..")
                {
                    if (stack.Count > 0)
                        stack.Pop();
                }
                else
                {
                    stack.Push(item);
                }
            }
            var counter = stack.Count;
            if (counter > 0)
            {
                var sentences = new List<string>();
                for (int i = 0; i < counter; i++)
                {
                    sentences.Add(stack.Pop());
                }
                sentences.Reverse();
                return "/" + string.Join("/", sentences);
            }
            else
                return "/";
        }
    }
}
