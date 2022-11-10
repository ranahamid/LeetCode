using System;

namespace LeetCode.Z
{
    public class _1217__Minimum_Cost_to_Move_Chips_to_The_Same_Position
    {
        /// <summary>
        /// Runtime: 176 ms, faster than 6.06% of C# online submissions for Minimum Cost to Move Chips to The Same Position.
        /// Memory Usage: 36.6 MB, less than 54.55% of C# online submissions for Minimum Cost to Move Chips to The Same Position.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public static int MinCostToMoveChips(int[] position)
        {
            var oddCount = 0;
            for (int i = 0; i < position.Length; i++)
            {
                if (position[i] % 2 == 1)
                {
                    oddCount++;
                }


            }
            var min = Math.Min(oddCount, position.Length - oddCount);
            return min;
        }

    }
}