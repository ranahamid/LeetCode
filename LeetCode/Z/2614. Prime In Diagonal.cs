using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2614
    {
        public int DiagonalPrime(int[][] nums)
        {
            int largestPrime = 0;

            int rows = nums.Length;
            int cols = nums[0].Length;

            // Check the main diagonal (top-left to bottom-right)
            for (int i = 0; i < rows; i++)
            {
                if (IsPrime(nums[i][i]) && nums[i][i] > largestPrime)
                {
                    largestPrime = nums[i][i];
                }
            }

            // Check the anti-diagonal (top-right to bottom-left)
            for (int i = 0; i < rows; i++)
            {
                if (IsPrime(nums[i][cols - i - 1]) && nums[i][cols - i - 1] > largestPrime)
                {
                    largestPrime = nums[i][cols - i - 1];
                }
            }

            return largestPrime;
        }
        private bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }


    }
}
