using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1038
    {
        /// <summary>
        /// Runtime: 113 ms, faster than 69.66% of C# online submissions for Binary Search Tree to Greater Sum Tree.
        /// Memory Usage: 37 MB, less than 17.98% of C# online submissions for Binary Search Tree to Greater Sum Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode BstToGst(TreeNode root)
        {
            var result = new SortedSet<int>();
            InOrder(root, result);
            var list = result.Reverse();
            var dic = new Dictionary<int, int>();
            var sum = 0;
            foreach (var item in list)
            {
                sum += item;
                dic[item] = sum;
            }
            ChangeBst(root, dic);
            return root;
        }
        public void InOrder(TreeNode root, SortedSet<int> result)
        {
            if (root == null)
                return;
            InOrder(root.left, result);
            result.Add(root.val);
            InOrder(root.right, result);
        }
        public void ChangeBst(TreeNode root, Dictionary<int, int> dic)
        {
            if (root == null)
                return;
            if (dic.ContainsKey(root.val))
                root.val = dic[root.val];
            ChangeBst(root.left, dic);
            ChangeBst(root.right, dic);
        }
    }
}
