using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_606
    {
        public int val;
        public TreeNode_606 left;
        public TreeNode_606 right;
        public TreeNode_606(int val = 0, TreeNode_606 left = null, TreeNode_606 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }


    internal class _606
    {
        public void Display()
        {
            TreeNode_606 sev = new TreeNode_606(4);
            TreeNode_606 six = new TreeNode_606(3);
            TreeNode_606 five = new TreeNode_606(2, null, sev);
            TreeNode_606 list2 = new TreeNode_606(1, five, six);

        }
        /// <summary>
        /// Runtime: 249 ms, faster than 7.69% of C# online submissions for Construct String from Binary Tree.
        /// Memory Usage: 41 MB, less than 92.31% of C# online submissions for Construct String from Binary Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static string Tree2str(TreeNode_606 root)
        {
            StringBuilder result = new StringBuilder();
            if (root != null)
            {
                result = Traverse(root, result);
            }
            var data = result.ToString(0, result.Length - 1);

            return data;
        }

        public static StringBuilder Traverse(TreeNode_606 current, StringBuilder result)
        {
            if (result.Length == 0)
                result.Append(current.val.ToString());
            else
            {
                result.Append("(");
                result.Append(current.val.ToString());
            }

            if (current.right != null && current.left == null)
            {
                result.Append("()");
            }

            if (current.left != null)
            {
                Traverse(current.left, result);
            }
            if (current.right != null)
            {
                Traverse(current.right, result);
            }

            if (result.Length != 0)
            {
                result.Append(")");
            }
            return result;
        }

    }
}
