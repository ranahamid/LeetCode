using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    class LRUCache
    {
        //Runtime 1003 ms Beats 75.92% Memory 142.8 MB Beats 21.29%

        IList<int> list; //without Ilist TLE
        int cap;
        Dictionary<int, int> dict;
        public LRUCache(int capacity)
        {
            cap = capacity;
            list = new List<int>();
            dict = new Dictionary<int, int>();
        }

        public int Get(int key)
        {
            if (dict.ContainsKey(key))
            {
                list.Remove(key);
                list.Add(key);
                return dict[key];
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (dict.ContainsKey(key))
            {
                dict[key] = value;
                list.Remove(key);
                list.Add(key);
                return;
            }
            else if (list.Count == cap)
            {

                var val = list[0];
                dict.Remove(val);
                list.Remove(val);
            }
            dict[key] = value;
            list.Add(key);
        }
    }
}
