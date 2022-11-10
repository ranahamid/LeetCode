using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class TimeMap
    {
        /// <summary>
        /// Runtime: 1143 ms, faster than 48.17% of C# online submissions for Time Based Key-Value Store.
        /// Memory Usage: 114.4 MB, less than 48.58% of C# online submissions for Time Based Key-Value Store.
        /// </summary>
        Dictionary<string, Dictionary<int, string>> map = new Dictionary<string, Dictionary<int, string>>();
        public TimeMap()
        {

        }
        public void Set(string key, string value, int timestamp)
        {
            map.TryAdd(key, new Dictionary<int, string>());
            map[key].Add(timestamp, value);
        }

        public string Get(string key, int timestamp)
        {
            for (int i = timestamp; i >= 0; i--)
            {
                if (map.ContainsKey(key) && map[key].ContainsKey(i))
                {
                    return map[key][i];
                }
            }
            return "";
        }
    }
}
