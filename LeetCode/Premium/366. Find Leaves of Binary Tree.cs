using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    public class TreeNode_366
    {
        public int val;
        public TreeNode_366 left;
        public TreeNode_366 right;
        public TreeNode_366(int val = 0, TreeNode_366 left = null, TreeNode_366 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _366
    {
        /// <summary>
        /// Runtime: 176 ms, faster than 74.94% of C# online submissions for Find Leaves of Binary Tree.
        /// Memory Usage: 40.6 MB, less than 97.95% of C# online submissions for Find Leaves of Binary Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> FindLeaves(TreeNode_366 root)
        {
            List<List<int>> result = new List<List<int>>();
            while (true)
            {
                var ints = new List<int>();
                var ans = PostOrder(root, ints);
                result.Add(ints);
                if (ans == 1)
                {
                    break;
                }
            }
            var list = result.Select(x => (IList<int>)x).ToList();
            return list;
        }
        public static int PostOrder(TreeNode_366 root, List<int> answerList)
        {
            if (root == null)
                return 0;
            var left = PostOrder(root.left, answerList);
            var right = PostOrder(root.right, answerList);
            if (root.left == null && root.right == null)
            {
                answerList.Add(root.val);
                return 1;
            }
            if (left == 1)
            {
                root.left = null;
            }
            if (right == 1)
            {
                root.right = null;
            }
            return 0;
        }
    }
}
