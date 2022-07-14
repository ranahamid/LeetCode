using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TreeNode_653
    {
        public int val;
        public TreeNode_653 left;
        public TreeNode_653 right;
        public TreeNode_653(int val = 0, TreeNode_653 left = null, TreeNode_653 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _653
    {
        /// <summary>
        /// set
        /// Runtime: 164 ms, faster than 71.51% of C# online submissions for Two Sum IV - Input is a BST.
        /// Memory Usage: 41.8 MB, less than 89.74% of C# online submissions for Two Sum IV - Input is a BST.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool FindTarget(TreeNode_653 root, int k)
        {
            if (root == null)
                return false;
            Queue<TreeNode_653> queue = new Queue<TreeNode_653>();
            queue.Enqueue(root);
            HashSet<int> set = new HashSet<int>();
            while (queue.Count > 0)
            {
                TreeNode_653 node = queue.Dequeue();
                var req = k - node.val;
                if (set.Contains(req))
                    return true;
                set.Add(node.val);
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            return false;
        }



        /// <summary>
        /// Runtime: 159 ms, faster than 74.93% of C# online submissions for Two Sum IV - Input is a BST.
        /// Memory Usage: 42.2 MB, less than 65.81% of C# online submissions for Two Sum IV - Input is a BST.
        /// own
        /// </summary>
        /// <param name="root"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool FindTarget_2(TreeNode_653 root, int k)
        {
            var result = new List<int>();
            if (root == null)
                return false;
            Queue<TreeNode_653> queue = new Queue<TreeNode_653>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode_653 node = queue.Dequeue();
                result.Add(node.val);
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 1; j < result.Count; j++)
                {
                    if (i != j && result[i] + result[j] == k)
                    {
                        return true;

                    }
                }
            }
            return false;
        }
    }
}
