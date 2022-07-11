using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _100
    {
        /// <summary>
        /// Runtime: 153 ms, faster than 32.29% of C# online submissions for Same Tree.
        /// Memory Usage: 38.7 MB, less than 42.27% of C# online submissions for Same Tree.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns></returns>
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (p == null && q != null)
                return false;
            if (p != null && q == null)
                return false;
            if (p.val != q.val)
                return false;
            Queue<TreeNode> queueP = new Queue<TreeNode>();

            Queue<TreeNode> queueQ = new Queue<TreeNode>();
            queueP.Enqueue(p);
            queueQ.Enqueue(q);

            while (queueP.Count > 0 || queueQ.Count > 0)
            {
                if (queueP.Count != queueQ.Count)
                    return false;

                TreeNode nodeP = queueP.Dequeue();
                TreeNode nodeQ = queueQ.Dequeue();

                if (nodeP.left == null && nodeQ.left != null)
                    return false;
                if (nodeP.left != null && nodeQ.left == null)
                    return false;

                if (nodeP.left != null)
                {
                    queueP.Enqueue(nodeP.left);
                }
                if (nodeQ.left != null)
                {
                    queueQ.Enqueue(nodeQ.left);
                }
                if (nodeP.left != null && nodeQ.left != null)
                {
                    if (nodeP.left.val != nodeQ.left.val)
                        return false;
                }


                if (nodeP.right == null && nodeQ.right != null)
                    return false;
                if (nodeP.right != null && nodeQ.right == null)
                    return false;
                if (nodeP.right != null)
                {
                    queueP.Enqueue(nodeP.right);
                }
                if (nodeQ.right != null)
                {
                    queueQ.Enqueue(nodeQ.right);
                }
                if (nodeP.right != null && nodeQ.right != null)
                {
                    if (nodeP.right.val != nodeQ.right.val)
                        return false;
                }
            }
            return true;
        }

    }
}
