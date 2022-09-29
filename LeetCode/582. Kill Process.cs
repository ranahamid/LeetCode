using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _582
    {
        /// <summary>
        /// Runtime: 243 ms, faster than 100.00% of C# online submissions for Kill Process.
        /// Memory Usage: 57.2 MB, less than 20.83% of C# online submissions for Kill Process.
        /// </summary>
        /// <param name="pid"></param>
        /// <param name="ppid"></param>
        /// <param name="kill"></param>
        /// <returns></returns>
        public IList<int> KillProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            var stack = new Stack<int>();
            var dic = new Dictionary<int, List<int>>();
            for (int i = 0; i < pid.Count; i++)
            {
                dic.TryAdd(ppid[i], new List<int>());
                dic[ppid[i]].Add(pid[i]);
            }
            var result = new List<int>();
            result.Add(kill);
            if (dic.ContainsKey(kill))
            {
                var values = dic[kill];
                foreach (var item in values)
                    stack.Push(item);
            }

            while (stack.Count > 0)
            {
                var child = stack.Pop();
                result.Add(child);

                if (dic.ContainsKey(child))
                {
                    var values = dic[child];
                    foreach (var item in values)
                        stack.Push(item);
                }

            }
            return result;
        }
    }
}
