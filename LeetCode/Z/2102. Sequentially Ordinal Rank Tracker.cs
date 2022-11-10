using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class SORTracker
    {
        /// <summary>
        /// Runtime 2538 ms Beats 33.33% Memory 90.2 MB Beats 44.44%
        /// </summary>
        int counter;
        SortedList<string, string> sortedList;
        public SORTracker()
        {
            counter = 0;
            sortedList = new SortedList<string, string>();
        }

        public void Add(string name, int score)
        {
            var key = int.MaxValue - score;
            var keyVal = key + name;
            sortedList.Add(keyVal, name);
        }

        public string Get()
        {
            var value = sortedList.Values[counter];
            counter++;
            return value;
        }
    }
}
