using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SmallestInfiniteSet
    {
        private SortedSet<int> set = new SortedSet<int>();

        public SmallestInfiniteSet()
        {
            for (int i = 1; i <= 1000; i++)
            {
                set.Add(i);
            }
        }

        public int PopSmallest()
        {
            var item = set.First();
            set.Remove(item);
            return item;
        }

        public void AddBack(int num)
        {
            set.Add(num);
        }
    }
}
