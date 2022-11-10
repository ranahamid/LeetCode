using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class TreeNode_108
    {
        public int val;
        public TreeNode_108 left;
        public TreeNode_108 right;
        public TreeNode_108(int val = 0, TreeNode_108 left = null, TreeNode_108 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _108
    {
        /// <summary>
        /// Runtime: 97 ms, faster than 86.33% of C# online submissions for Convert Sorted Array to Binary Search Tree.
        /// Memory Usage: 37.7 MB, less than 63.46% of C# online submissions for Convert Sorted Array to Binary Search Tree.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public TreeNode_108 SortedArrayToBST(int[] nums)
        {
            var result = BuildBST(nums, 0, nums.Length - 1);
            return result;
        }
        public static TreeNode_108 BuildBST(int[] nums, int left, int right)
        {
            if (left > right)
                return null;
            var mid = left + (right - left) / 2;
            var node = new TreeNode_108(nums[mid]);
            node.left = BuildBST(nums, left, mid - 1);
            node.right = BuildBST(nums, mid + 1, right);
            return node;
        }
    }
}
