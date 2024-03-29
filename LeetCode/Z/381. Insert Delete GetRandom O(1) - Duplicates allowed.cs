﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    /// <summary>
    /// Runtime: 669 ms, faster than 48.00% of C# online submissions for Insert Delete GetRandom O(1) - Duplicates allowed.
    /// Memory Usage: 100.1 MB, less than 84.00% of C# online submissions for Insert Delete GetRandom O(1) - Duplicates allowed.
    /// </summary>
    public class RandomizedCollection
    {
        List<int> set;
        Random rd;
        public RandomizedCollection()
        {
            set = new List<int>();
            rd = new Random();

        }

        public bool Insert(int val)
        {
            if (set.Contains(val))
            {
                set.Add(val);
                return false;
            }
            else
            {
                set.Add(val);
                return true;
            }
        }

        public bool Remove(int val)
        {
            if (set.Contains(val))
            {
                set.Remove(val);
                return true;
            }
            else
            {
                return false;
            }

        }

        public int GetRandom()
        {
            var length = set.Count;

            int rand_num = rd.Next(0, length);
            return set.ElementAt(rand_num);
        }
    }

    /**
     * Your RandomizedCollection object will be instantiated and called as such:
     * RandomizedCollection obj = new RandomizedCollection();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
