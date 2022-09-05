using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    internal class _426
    {
        /// <summary>
        /// Runtime: 87 ms, faster than 99.04% of C# online submissions for Convert Binary Search Tree to Sorted Doubly Linked List.
        /// Memory Usage: 39.1 MB, less than 5.77% of C# online submissions for Convert Binary Search Tree to Sorted Doubly Linked List.
        /// </summary>
        Node first = null;
        Node last = null;

        public Node TreeToDoublyList(Node root)
        {
            if (root == null)
                return null;
            DFS(root);

            last.right = first;
            first.left = last;
            return first;
        }
        public void DFS(Node root)
        {
            if (root == null)
                return;
            DFS(root.left);
            if (last != null)
            {
                last.right = root;
                root.left = last;
            }
            else
            {
                first = root;
            }
            last = root;

            DFS(root.right);
        }
    }
}
