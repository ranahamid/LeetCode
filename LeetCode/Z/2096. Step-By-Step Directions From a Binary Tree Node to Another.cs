using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2096
    {
        /// <summary>
        ///Runtime: 354 ms, faster than 88.06% of C# online submissions for Step-By-Step Directions From a Binary Tree Node to Another.
        ///Memory Usage: 67.2 MB, less than 53.23% of C# online submissions for Step-By-Step Directions From a Binary Tree Node to Another.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="destValue"></param>
        /// <param name="sb"></param>
        /// <returns></returns>
        public bool SearchNode(TreeNode root, int destValue, StringBuilder sb)
        {
            if (root.val == destValue)
                return true;
            else if (root.left != null && SearchNode(root.left, destValue, sb))
                sb.Append("L");
            else if (root.right != null && SearchNode(root.right, destValue, sb))
                sb.Append("R");
            return sb.Length > 0;
        }
        public string GetDirections(TreeNode root, int startValue, int destValue)
        {
            StringBuilder start = new StringBuilder();
            SearchNode(root, startValue, start);

            StringBuilder dest = new StringBuilder();
            SearchNode(root, destValue, dest);

            var minLen = Math.Min(start.Length, dest.Length);
            int i = 0;
            while (i < minLen && start[start.Length - 1 - i] == dest[dest.Length - 1 - i])
                i++;


            var aa = string.Concat(Enumerable.Repeat("U", start.Length - i));
            var b = new StringBuilder(new string(dest.ToString().Reverse().ToArray()));
            var bb = b.ToString().Substring(i, b.Length - i);
            return aa + bb;
        }
        /// Runtime: 378 ms, faster than 83.58% of C# online submissions for Step-By-Step Directions From a Binary Tree Node to Another.
        /// Memory Usage: 66.8 MB, less than 59.20% of C# online submissions for Step-By-Step Directions From a Binary Tree Node to Another.
        public string GetDirections_Reverse(TreeNode root, int startValue, int destValue)
        {
            StringBuilder start = new StringBuilder();
            SearchNode(root, startValue, start);

            StringBuilder dest = new StringBuilder();
            SearchNode(root, destValue, dest);

            var minLen = Math.Min(start.Length, dest.Length);
            var a = new StringBuilder(new string(start.ToString().Reverse().ToArray()));
            var b = new StringBuilder(new string(dest.ToString().Reverse().ToArray()));
            int i = 0;
            while (i < minLen && a[i] == b[i])
            {
                i++;
            }
            var aa = string.Concat(Enumerable.Repeat("U", a.Length - i));
            var bb = b.ToString().Substring(i, dest.Length - i);
            return aa + bb;
        }
    }
}
