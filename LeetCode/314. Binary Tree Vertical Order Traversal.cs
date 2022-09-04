using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _314
    {
        /// <summary>
        /// Runtime: 224 ms, faster than 45.56% of C# online submissions for Binary Tree Vertical Order Traversal.
        /// Memory Usage: 41.8 MB, less than 84.81% of C# online submissions for Binary Tree Vertical Order Traversal.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return result;
            var queue = new Queue<(int offset, TreeNode node)>();
            var dic = new SortedDictionary<int, List<int>>();
            queue.Enqueue((0, root));
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                if (!dic.ContainsKey(item.offset))
                {
                    dic.Add(item.offset, new List<int>());
                }
                dic[item.offset].Add(item.node.val);

                if (item.node.left != null)
                {
                    queue.Enqueue((item.offset - 1, item.node.left));
                }
                if (item.node.right != null)
                {
                    queue.Enqueue((item.offset + 1, item.node.right));
                }
            }
            foreach (var item in dic)
            {
                result.Add(item.Value);
            }
            return result;
        }
    }
}
