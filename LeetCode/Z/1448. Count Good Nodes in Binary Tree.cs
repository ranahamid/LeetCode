using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1448
    {
        public class PairNode
        {
            public int CurrentMax;
            public TreeNode Node;
            public PairNode(TreeNode node, int currentMax)
            {
                CurrentMax = currentMax;
                Node = node;
            }
        }
        public int GoodNodes(TreeNode root)
        {
            var result = 0;
            var queue = new Queue<PairNode>();
            queue.Enqueue(new PairNode(root, int.MinValue));
            while (queue.Count > 0)
            {
                var currentNode = queue.Dequeue();
                if (currentNode.CurrentMax <= currentNode.Node.val)
                {
                    result++;
                }
                if (currentNode.Node.left != null)
                {
                    queue.Enqueue(new PairNode(currentNode.Node.left, Math.Max(currentNode.CurrentMax, currentNode.Node.val)));
                }
                if (currentNode.Node.right != null)
                {
                    queue.Enqueue(new PairNode(currentNode.Node.right, Math.Max(currentNode.CurrentMax, currentNode.Node.val)));
                }
            }
            return result;
        }
    }
}
