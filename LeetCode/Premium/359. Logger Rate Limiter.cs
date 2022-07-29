using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    public class Logger
    {
        private Dictionary<string, int> visited;
        public Logger()
        {
            visited = new Dictionary<string, int>();
        }

        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if (visited.ContainsKey(message))
            {
                var val = visited[message];
                if (val + 10 > timestamp)
                {
                    return false;
                }
                visited[message] = timestamp;
                return true;
            }
            else
            {
                visited[message] = timestamp;
                return true;
            }
        }
    }
}
