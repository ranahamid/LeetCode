using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class _112
	{
		/// <summary>
		/// Runtime: 118 ms, faster than 81.01% of C# online submissions for Path Sum.
		/// Memory Usage: 40.8 MB, less than 21.94% of C# online submissions for Path Sum.
		/// </summary>
		/// <param name="root"></param>
		/// <param name="targetSum"></param>
		/// <returns></returns>
		public bool HasPathSum(TreeNode root, int targetSum)
		{
			if (root == null)
				return false;
			targetSum = targetSum - root.val;
			if (root.left == null && root.right == null)
			{
				return targetSum == 0;
			}
			return HasPathSum(root.left, targetSum) || HasPathSum(root.right, targetSum);
		}
	}
}
