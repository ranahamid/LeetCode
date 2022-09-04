using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _257
    {
        /// <summary>
        /// Runtime: 224 ms, faster than 51.54% of C# online submissions for Binary Tree Paths.
        /// Memory Usage: 43.2 MB, less than 24.38% of C# online submissions for Binary Tree Paths.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<string> BinaryTreePaths(TreeNode root)
        {
            if (root == null)
                return new List<string>();

            List<List<int>> res = new List<List<int>>();
            List<int> nums = new List<int>();
            nums.Add(root.val);
            DFS(root, res, nums);
            var result = new List<string>();
            foreach (var item in res)
            {
                var sb = new StringBuilder();
                for (int i = 0; i < item.Count; i++)
                {
                    sb.Append(item[i]);
                    if (i < item.Count - 1)
                    {
                        sb.Append("->");
                    }
                }
                result.Add(sb.ToString());
            }
            return result;
        }
        public void DFS(TreeNode root, List<List<int>> res, List<int> nums)
        {
            if (root.left == null && root.right == null)
            {
                res.Add(nums);
                return;
            }
            if (root.left != null)
            {
                List<int> temp = new List<int>();
                foreach (var item in nums)
                {
                    temp.Add(item);
                }
                temp.Add(root.left.val);
                DFS(root.left, res, temp);
            }
            if (root.right != null)
            {
                List<int> temp = new List<int>();
                foreach (var item in nums)
                {
                    temp.Add(item);
                }
                temp.Add(root.right.val);
                DFS(root.right, res, temp);
            }
        }
    }
}
