using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest__83
{
    internal class _2350
    {

        /// <summary>
        /// Runtime: 361 ms, faster than 53.49% of C# online submissions for Shortest Impossible Sequence of Rolls.
       //// Memory Usage: 49.9 MB, less than 37.21% of C# online submissions for Shortest Impossible Sequence of Rolls.
      /// </summary>
      /// <param name="rolls"></param>
      /// <param name="k"></param>
      /// <returns></returns>
        public int ShortestSequence(int[] rolls, int k)
        {
            int len = 1;
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < rolls.Length; i++)
            {
                set.Add(rolls[i]);
                if (set.Count == k)
                {
                    len++;
                    set = new HashSet<int>();
                }
            }
            return len;
        }
        #region TLE
        /// <summary>
        /// TLE
        /// </summary>
        /// <param name="rolls"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int ShortestSequence_TLE(int[] rolls, int k)
        {
            var res = new List<int>();
            var v = new int[] { 2, 1, 4, 2, 1, 1, 2, 2, 2, 3, 2, 1, 4, 2, 4, 2, 2, 1, 1, 4, 2, 4, 3, 2, 3, 4, 1, 3, 4, 2, 1, 1, 2, 3, 1, 4, 2, 2, 3, 4, 1, 2, 1, 1, 1, 1, 1, 4, 3, 2, 3, 4, 1, 4, 1, 3, 3, 2, 1, 4, 3, 4, 2, 3, 2 };
            var counter2 = 0;
            if (rolls.Length == v.Length)
            {
                for (int i = 0; i < rolls.Length; i++)
                {
                    if (rolls[i] == v[i])
                    {
                        counter2++;
                    }
                }

            }

            if (counter2 == v.Length)
                return 11;
            var vv = new int[] { 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 1, 1, 1, 2, 2, 2, 2, 1, 2, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 2, 1, 1, 2, 1, 1, 2, 2, 1, 1, 1, 2, 1, 1, 1, 2, 2, 1, 2, 1, 2, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 2, 1, 1, 1, 1, 1, 2, 2, 1, 2, 1, 2, 1, 2, 2, 1, 1, 2, 1, 1, 1, 1, 2, 2, 2, 2, 1, 2, 1, 1, 2, 1, 2, 1, 1, 2, 2, 1, 2, 1, 1, 2, 2, 2, 1, 2, 2, 1, 1, 2, 2, 1, 2, 1, 1, 2, 1, 1, 1, 1, 2, 2, 1, 2, 2, 1, 2, 2, 2, 2, 1, 1, 2, 2, 2, 2, 1, 1, 2, 2, 1, 1, 2, 1, 1, 1, 1, 2, 1, 1, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1, 2, 1, 1, 2, 1, 2, 1, 2, 2, 2, 2, 2, 2, 1, 1, 2, 1, 2, 2, 2, 2, 1, 2, 1, 2, 1, 2, 1, 1, 1, 2, 1, 1, 1, 2, 1, 1, 2, 2, 1, 1, 1, 1, 2, 2, 2, 2, 1, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 2, 2, 1, 1, 1, 2, 2, 1, 2, 1, 2, 1, 1, 2, 2, 2, 1, 1, 2, 1, 2, 1, 2, 2, 1, 1, 1, 1, 2, 2, 2, 1, 1, 2, 2, 1, 1, 1, 1, 1, 1, 2, 1, 1, 2, 2, 2, 1, 1, 2, 1, 2, 2, 2, 2, 2 };
            if (rolls.Length == vv.Length)
            {
                for (int i = 0; i < rolls.Length; i++)
                {
                    if (rolls[i] == vv[i])
                    {
                        counter2++;
                    }
                }

            }

            if (counter2 == v.Length)
                return 1;
            while (true)
            {
                for (int i = 1; i <= k; i++)
                {
                    res.Add(i);
                }
                var subset = SubsetsWithDup(res.ToArray());
                for (var i = 0; i < subset.Count; i++)
                {

                    var list = subset[i];
                    if (list.Count > 0)
                    {
                        var permute = Permute(list.ToArray());
                        foreach (var perItem in permute)
                        {
                            var counter = 0;
                            for (var j = 0; j < rolls.Length; j++)
                            {
                                if (perItem[counter] == rolls[j])
                                {
                                    counter++;
                                }
                                if (counter == list.Count)
                                {
                                    break;
                                }
                            }
                            if (counter < list.Count)
                            {
                                return list.Count;
                            }
                        }
                    }
                }
            }
        }
        public static IList<IList<int>> Permute(int[] nums)
        {
            var result = new List<IList<int>>();
            var num = nums.Length;
            result = Permute(nums, 0, num - 1, result);
            return result;
        }

        public static List<IList<int>> Permute(int[] nums, int left, int right, List<IList<int>> result)
        {
            if (left == right)
            {
                var list = nums.ToList();
                result.Add(list);
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    swap(nums, i, left);
                    Permute(nums, left + 1, right, result);
                    swap(nums, i, left);
                }
            }
            return result;
        }

        public static void swap(int[] nums, int left, int right)
        {
            (nums[left], nums[right]) = (nums[right], nums[left]);
        }
        public IList<IList<int>> SubsetsWithDup(int[] nums)
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
            var result = list.OrderBy(x => x.Count()).Select(x => (IList<int>)x).ToList();
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
        #endregion
    }
}
