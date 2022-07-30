using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode_109
    {
        public int val;
        public ListNode_109 next;
        public ListNode_109(int val = 0, ListNode_109 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class TreeNode_109
    {
        public int val;
        public TreeNode_109 left;
        public TreeNode_109 right;
        public TreeNode_109(int val = 0, TreeNode_109 left = null, TreeNode_109 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    internal class _109
    {
        /// <summary>
        /// Runtime: 95 ms, faster than 95.77% of C# online submissions for Convert Sorted List to Binary Search Tree.
        /// Memory Usage: 40 MB, less than 42.25% of C# online submissions for Convert Sorted List to Binary Search Tree.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public TreeNode_109 SortedListToBST(ListNode_109 head)
        {
            var nums = new List<int>();
            while (head != null)
            {
                nums.Add(head.val);
                head = head.next;
            }
            var result = BuildBST(nums.ToArray(), 0, nums.Count - 1);
            return result;
        }
        public static TreeNode_109 BuildBST(int[] nums, int left, int right)
        {
            if (left > right)
                return null;
            var mid = left + (right - left) / 2;
            var node = new TreeNode_109(nums[mid]);
            node.left = BuildBST(nums, left, mid - 1);
            node.right = BuildBST(nums, mid + 1, right);
            return node;
        }
    }
}
