using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_2236
    {
        public int val;
        public TreeNode_2236 left;
        public TreeNode_2236 right;
        public TreeNode_2236(int val = 0, TreeNode_2236 left = null, TreeNode_2236 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _2236_Root_Equals_Sum_of_Children
    {
        public void display()
        {
            TreeNode_2236 six = new TreeNode_2236(6);
            TreeNode_2236 five = new TreeNode_2236(4);
            TreeNode_2236 list2 = new TreeNode_2236(10, five, six);
            Console.Write(CheckTree(list2));
        }
        /// <summary>
        /// Runtime: 103 ms, faster than 87.01% of C# online submissions for Root Equals Sum of Children.
        /// Memory Usage: 38.9 MB, less than 96.75% of C# online submissions for Root Equals Sum of Children.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static bool CheckTree(TreeNode_2236 root)
        {
            if (root != null)
            {
                var firstNumber = root.val;
                var left = root.left != null ? root.left.val : 0;
                var right = root.right != null ? root.right.val : 0;
                if (firstNumber == left + right)
                    return true;

            }
            return false;
        }
    }
}
