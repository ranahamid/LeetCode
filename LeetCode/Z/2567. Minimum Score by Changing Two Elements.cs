csusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    class _2567
	{
		/// <summary>
		/// Runtime: 166 ms, faster than 55.22% of C# online submissions for Minimum Score by Changing Two Elements.
		/// Memory Usage: 50.2 MB, less than 34.33% of C# online submissions for Minimum Score by Changing Two Elements.
		/// </summary>
		/// <param name="nums"></param>
		/// <returns></returns>
		public int MinimizeSum(int[] nums)
		{

			Array.Sort(nums);
			var n = nums.Length;
			///			remove the smallest two numbers
			///remove the largest two numbers
			///remove the smallest and largest
			///
			return Math.Min(Math.Min(nums[n - 3] - nums[0], nums[n - 2] - nums[1]), nums[n - 1] - nums[2]);
		}
	}
}
