using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class Node_589 {
        public int val;
        public IList<Node_589> children;

        public Node_589() {}

        public Node_589(int _val) {
            val = _val;
        }

        public Node_589(int _val,IList<Node_589> _children) {
            val = _val;
            children = _children;
        }
    }
    public class _589__N_ary_Tree_Preorder_Traversal {
        /// <summary>
        /// Runtime: 266 ms, faster than 43.32% of C# online submissions for N-ary Tree Preorder Traversal.
        /// Memory Usage: 45.4 MB, less than 61.34% of C# online submissions for N-ary Tree Preorder Traversal.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> Preorder(Node_589 root) {
            List<int> result = new List<int>();
            if(root!=null)
            { 
                result = Traverse(root,result);
            }
            return result;
        }
         

        public static List<int> Traverse(Node_589 current, List<int> result )
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