using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _95
    {
        /// <summary>
        /// Runtime: 136 ms, faster than 60.16% of C# online submissions for Unique Binary Search Trees II.
        /// Memory Usage: 37.6 MB, less than 63.41% of C# online submissions for Unique Binary Search Trees II.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0)
                return new List<TreeNode>();
            return Generate(1, n);
        }
        public IList<TreeNode> Generate(int start, int end)
        {
            var result = new List<TreeNode>();
            if (start > end)
            {

                result.Add(null);
                return result;
            }
            for (int i = start; i <= end; i++)
            {
                var left = Generate(start, i - 1);
                var right = Generate(i + 1, end);
                foreach (var l in left)
                    foreach (var r in right)
                    {
                        var node = new TreeNode(i);
                        node.left = l;
                        node.right = r;
                        result.Add(node);
                    }
            }
            return result;
        }
    }
}
