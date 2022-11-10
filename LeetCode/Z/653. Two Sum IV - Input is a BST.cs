using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
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
        /// Runtime: 171 ms, faster than 67.65% of C# online submissions for Two Sum IV - Input is a BST.
        ///Memory Usage: 42 MB, less than 68.01% of C# online submissions for Two Sum IV - Input is a BST.
        /// </summary>
        #region recursive
        HashSet<int> set = new HashSet<int>();
        bool result = false;
        public bool FindTarget(TreeNode root, int k)
        {
            set = new HashSet<int>();
            return Target(root, k);
        }

        public bool Target(TreeNode root, int k)
        {
            if (result)
                return true;
            if (root == null)
                return false;
            if (set.Contains(k - root.val))
                return true;
            else
                set.Add(root.val);
            return Target(root.left, k) || Target(root.right, k);
        }
        #endregion
        /// <summary>
        /// set
        /// Runtime: 164 ms, faster than 71.51% of C# online submissions for Two Sum IV - Input is a BST.
        /// Memory Usage: 41.8 MB, less than 89.74% of C# online submissions for Two Sum IV - Input is a BST.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool FindTarget_iterative(TreeNode_653 root, int k)
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
