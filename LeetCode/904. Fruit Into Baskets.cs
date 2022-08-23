using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _904
    {
        /// <summary>
        /// Runtime: 215 ms, faster than 97.94% of C# online submissions for Fruit Into Baskets.
        /// Memory Usage: 52.5 MB, less than 9.25% of C# online submissions for Fruit Into Baskets.
        /// </summary>
        /// <param name="fruits"></param>
        /// <returns></returns>
        public int TotalFruit(int[] fruits)
        {
            var dict = new Dictionary<int, int>();
            int i = 0, j;
            for (j = 0; j < fruits.Length; j++)
            {
                if (dict.ContainsKey(fruits[j]))
                    dict[fruits[j]]++;
                else
                    dict[fruits[j]] = 1;
                if (dict.Count > 2)
                {
                    dict[fruits[i]]--;
                    if (dict[fruits[i]] == 0)
                        dict.Remove(fruits[i]);
                    i++;
                }
            }
            return j - i;
        }
    }
}
