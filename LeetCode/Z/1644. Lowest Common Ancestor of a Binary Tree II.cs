using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1644
    {
        #region traverse
        bool isPfound = false;
        bool isQfound = false;
        public TreeNode LowestCommonAncestor_1(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            var node = FoundLowestAncestor(root, p, q);
            return isPfound && isQfound ? node : null;
        }
        public TreeNode FoundLowestAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;

            var left = FoundLowestAncestor(root.left, p, q);
            var right = FoundLowestAncestor(root.right, p, q);

            if (root == p)
            {
                isPfound = true;
                return root;
            }
            if (root == q)
            {
                isQfound = true;
                return root;
            }
            if (left == null)
                return right;
            if (right == null)
                return left;
            return root;
        }
        #endregion
        #region self
        /// <summary>
        /// Runtime: 193 ms, faster than 80.49% of C# online submissions for Lowest Common Ancestor of a Binary Tree II.
        /// Memory Usage: 55.3 MB, less than 7.32% of C# online submissions for Lowest Common Ancestor of a Binary Tree II.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            List<int> result = new List<int>();
            Traverse(root, result);
            var isPfound = result.Count(x => x == p.val) > 0;
            var isQfound = result.Count(x => x == q.val) > 0;
            Console.WriteLine(isPfound);
            Console.WriteLine(isQfound);
            if (!isPfound || !isQfound)
            {
                return null;
            }
            return FoundLowest(root, p, q);
        }
        public TreeNode FoundLowest(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            if (root.val == p.val || root.val == q.val)
                return root;
            var left = FoundLowest(root.left, p, q);
            var right = FoundLowest(root.right, p, q);
            if (left == null)
                return right;
            if (right == null)
                return left;
            return root;
        }
        public List<int> Traverse(TreeNode current, List<int> result)
        {
            if (current.left != null)
                Traverse(current.left, result);
            result.Add(current.val);
            if (current.right != null)
                Traverse(current.right, result);
            return result;
        }
        #endregion
    }
}
