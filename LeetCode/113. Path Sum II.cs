using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _113
    {
        /// <summary>
        /// Runtime: 202 ms, faster than 62.24% of C# online submissions for Path Sum II.
        /// Memory Usage: 42.8 MB, less than 95.87% of C# online submissions for Path Sum II.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="targetSum"></param>
        /// <returns></returns>
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            List<IList<int>> pathList = new List<IList<int>>();
            List<int> paths = new List<int>();
            PathFind(root, targetSum, pathList, paths);
            return pathList;
        }
        public void PathFind(TreeNode root, int targetSum, List<IList<int>> pathList, List<int> paths)
        {
            if (root == null)
                return;
            paths.Add(root.val);
            if (targetSum - root.val == 0 && root.left == null && root.right == null)
            {
                List<int> tmp = new List<int>();
                foreach (var item in paths)
                {
                    tmp.Add(item);
                }
                pathList.Add(tmp);
            }
            else
            {
                PathFind(root.left, targetSum - root.val, pathList, paths);
                PathFind(root.right, targetSum - root.val, pathList, paths);
            }
            paths.RemoveAt(paths.Count - 1);
        }
    }
}
