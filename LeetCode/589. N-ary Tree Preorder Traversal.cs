using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class _589__N_ary_Tree_Preorder_Traversal {
        /// <summary>
        /// Runtime: 266 ms, faster than 43.32% of C# online submissions for N-ary Tree Preorder Traversal.
        /// Memory Usage: 45.4 MB, less than 61.34% of C# online submissions for N-ary Tree Preorder Traversal.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> Preorder(Node root) {
            List<int> result = new List<int>();
            if(root!=null)
            { 
                result = Traverse(root,result);
            }
            return result;
        }
         

        public static List<int> Traverse(Node current, List<int> result )
        {
            result.Add(current.val);
            if (current.children != null && current.children.Any())
            {
                foreach (var currentChild in current.children)
                {
                    Traverse(currentChild, result); 
                }
            }
            return result;
        }

    }
}