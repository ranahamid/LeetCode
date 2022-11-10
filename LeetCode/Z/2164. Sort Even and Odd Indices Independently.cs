using System;
using System.Collections.Generic;

namespace LeetCode.Z
{
    public class _2164__Sort_Even_and_Odd_Indices_Independently
    {

        public int[] SortEvenOdd(int[] nums)
        {
            var odd = new List<int>(); var even = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                    even.Add(nums[i]);
                else
                {
                    odd.Add(nums[i]);
                }
            }

            var od = odd.ToArray();
            Array.Sort(od, (a, b) => b.CompareTo(a));
            even.Sort();
            var result = new int[nums.Length];
            var evenCount = 0;
            var oddCounter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                    result[i] = even[evenCount++];
                else
                {

                    result[i] = od[oddCounter++];
                }
            }

            return result;
        }


    }
}