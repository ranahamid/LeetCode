using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2196
    {
        /// <summary>
        /// Runtime 784 ms Beats 58.82% Memory 49.6 MB Beats 33.33%
        /// </summary>
        /// <param name="descriptions"></param>
        /// <returns></returns>
        public TreeNode CreateBinaryTree(int[][] descriptions)
        {
            var dic = new Dictionary<int, TreeNode>();
            foreach (var desc in descriptions)
            {
                int parent = desc[0];
                int child = desc[1];
                if (!dic.ContainsKey(parent))
                    dic.Add(parent, new TreeNode(parent));

                if (!dic.ContainsKey(child))
                    dic.Add(child, new TreeNode(child));
            }
            foreach (var desc in descriptions)
            {
                if (desc[2] == 1)
                    dic[desc[0]].left = dic[desc[1]];
                else
                    dic[desc[0]].right = dic[desc[1]];
            }
            var parents = descriptions.Select(x => x[0]).ToHashSet();
            var childs = descriptions.Select(x => x[1]).ToHashSet();
            var root = parents.Where(x => !childs.Contains(x)).FirstOrDefault();
            return dic[root];
        }
    }
}
