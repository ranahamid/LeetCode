using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _90_Subsets_II
    {
        /// <summary>
        /// Runtime: 271 ms, faster than 6.17% of C# online submissions for Subsets II.
        /// Memory Usage: 42.3 MB, less than 26.67% of C# online submissions for Subsets II.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            int[] output = new int[0];
            List<IList<int>> list = new List<IList<int>>();
            list.Add(new List<int>());
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            var counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    list.Add(new List<int> { nums[i] });
                    dictionary.Add(counter++, ConvertToStringFromIntCommas(new List<int> { nums[i] }));
                }
                else
                {
                    var existingItems = list.Select(x => x.ToList()).ToList();
                    foreach (var item in existingItems)
                    {
                        item.Add(nums[i]);
                    }
                    foreach (var item in existingItems)
                    {
                        var st = ConvertToStringFromIntCommas(item);
                        if (dictionary.ContainsValue(st))
                        {

                        }
                        else
                        {
                            list.Add(item);
                            dictionary.Add(counter++, st);
                        }

                    }

                }
            }

            Console.WriteLine(list.Count());
            var result = list.Select(x => (IList<int>)x).ToList();
            return result;
        }

        public static string ConvertToStringFromIntCommas(List<int> names)
        {
            if (names != null && names.Count > 0)
            {
                names.Sort();
                var result = string.Join(",", names.ToArray());
                return result;
            }

            return "";
        }

    }
}
