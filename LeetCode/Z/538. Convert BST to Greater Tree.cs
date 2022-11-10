using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _538
    {
        #region recursion

        int sum = 0;
        public TreeNode ConvertBST(TreeNode root)
        {
            if (root == null)
                return null;
            ConvertBST(root.right);
            sum += root.val;
            root.val = sum;
            ConvertBST(root.left);
            return root;
        }
        #endregion
        /// <summary>
        /// Runtime: 92 ms, faster than 98.75% of C# online submissions for Convert BST to Greater Tree.
        /// Memory Usage: 46.9 MB, less than 6.25% of C# online submissions for Convert BST to Greater Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode ConvertBST_2(TreeNode root)
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
