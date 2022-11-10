using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _605
    {
        /// <summary>
        /// Runtime: 125 ms, faster than 83.98% of C# online submissions for Can Place Flowers.
        /// Memory Usage: 45.9 MB, less than 7.36% of C# online submissions for Can Place Flowers.
        /// </summary>
        /// <param name="flowerbed"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            if (n == 0)
                return true;

            for (int i = 0; i < flowerbed.Length; i++)
            {
                if (flowerbed[i] == 0)
                {
                    int prev = i == 0 ? 0 : flowerbed[i - 1];
                    int next = i == flowerbed.Length - 1 ? 0 : flowerbed[i + 1];
                    if (prev == 0 && next == 0)
                    {
                        n--;
                        flowerbed[i] = 1;
                    }
                }

            }
            if (n <= 0)
                return true;
            return false;
        }

        /// <summary>
        /// Runtime: 239 ms, faster than 7.36% of C# online submissions for Can Place Flowers.
        /// Memory Usage: 41 MB, less than 88.31% of C# online submissions for Can Place Flowers.
        /// </summary>
        /// <param name="flowerbed"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool CanPlaceFlowers_SELF(int[] flowerbed, int n)
        {
            if (n == 0)
                return true;
            if (flowerbed[0] == 0 && flowerbed.Length == 1)
            {
                n--;
                flowerbed[0] = 1;
            }

            if (flowerbed.Length == 2)
            {
                if (flowerbed[0] == 0 && flowerbed[1] == 0)
                {
                    n--;
                    flowerbed[0] = 1;
                }
            }
            if (flowerbed[0] == 0 && flowerbed[1] == 0)
            {
                n--;
                flowerbed[0] = 1;
            }
            if (n == 0)
                return true;
            for (int i = 1; i < flowerbed.Length - 1; i++)
            {

                if (flowerbed[i - 1] == 1 && flowerbed[i] == 0 && flowerbed[i + 1] == 0)
                {
                    if (i + 2 < flowerbed.Length && flowerbed[i + 2] == 1)
                    {
                        continue;
                    }
                    n--;
                    flowerbed[i + 1] = 1;
                }
                if (n == 0)
                    return true;
            }
            if (n == 0)
                return true;
            return false;
        }
    }
}
