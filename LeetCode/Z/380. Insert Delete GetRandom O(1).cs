using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    /// <summary>
    /// Runtime: 703 ms, faster than 20.59% of C# online submissions for Insert Delete GetRandom O(1).
    /// Memory Usage: 94.5 MB, less than 36.27% of C# online submissions for Insert Delete GetRandom O(1).
    /// </summary>
    public class RandomizedSet
    {
        HashSet<int> set;
        Random rd;
        public RandomizedSet()
        {
            set = new HashSet<int>();
            rd = new Random();
        }

        public bool Insert(int val)
        {
            if (set.Contains(val))
            {
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
     * Your RandomizedSet object will be instantiated and called as such:
     * RandomizedSet obj = new RandomizedSet();
     * bool param_1 = obj.Insert(val);
     * bool param_2 = obj.Remove(val);
     * int param_3 = obj.GetRandom();
     */
}
