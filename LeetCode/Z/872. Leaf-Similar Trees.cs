using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _872
    {
        /// <summary> 
        /// Runtime 96 ms Beats 96.88% Memory 40.8 MB Beats 5.21%
        /// </summary>
        /// <param name="root1"></param>
        /// <param name="root2"></param>
        /// <returns></returns>
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var list1 = DFS(root1, new List<int>());
            var list2 = DFS(root2, new List<int>());
            Console.WriteLine(String.Join(",", list1));
            Console.WriteLine(String.Join(",", list2));

            return list1.SequenceEqual(list2);
        }
        public List<int> DFS(TreeNode root, List<int> sequence)
        {
            if (root.left == null && root.right == null)
                sequence.Add(root.val);
            if (root.left != null)
                DFS(root.left, sequence);
            if (root.right != null)
                DFS(root.right, sequence);
            return sequence;
        }
    }
}
