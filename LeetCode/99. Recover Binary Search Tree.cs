using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _99
    {
        /// <summary>
        /// Runtime: 113 ms, faster than 89.60% of C# online submissions for Recover Binary Search Tree.
        /// Memory Usage: 46.8 MB, less than 5.20% of C# online submissions for Recover Binary Search Tree.
        /// </summary>
        /// <param name="root"></param>
        public void RecoverTree(TreeNode root)
        {
            List<int> result = new List<int>();
            InOrder(root, result);
            var diff = FindDifferences(result);
            Recover(root, diff, 2);
        }
        public void Recover(TreeNode root, int[] diff, int count)
        {
            if (root == null)
                return;

            int x = diff[0];
            int y = diff[1];
            Console.WriteLine(x);
            Console.WriteLine(y);
            if (root.val == x || root.val == y)
            {
                root.val = root.val == x ? y : x;
                count--;
                if (count == 0)
                    return;
            }
            Recover(root.left, diff, count);
            Recover(root.right, diff, count);
        }

        public void InOrder(TreeNode root, List<int> result)
        {
            if (root == null)
                return;
            InOrder(root.left, result);
            result.Add(root.val);
            InOrder(root.right, result);
        }

        public int[] FindDifferences(List<int> result)
        {
            int x = -1;
            int y = -1;
            var isFound = false;
            for (int i = 0; i < result.Count - 1; i++)
            {
                if (result[i + 1] < result[i])
                {
                    y = result[i + 1];
                    if (!isFound)
                    {
                        x = result[i];
                        isFound = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return new int[] { x, y };
        }
    }
}
