using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Node_426
    {
        public int val;
        public Node_426 left;
        public Node_426 right;

        public Node_426() { }

        public Node_426(int _val)
        {
            val = _val;
            left = null;
            right = null;
        }

        public Node_426(int _val, Node_426 _left, Node_426 _right)
        {
            val = _val;
            left = _left;
            right = _right;
        }
    }
    internal class _426
    {
        /// <summary>
        /// Runtime: 87 ms, faster than 99.04% of C# online submissions for Convert Binary Search Tree to Sorted Doubly Linked List.
        /// Memory Usage: 39.1 MB, less than 5.77% of C# online submissions for Convert Binary Search Tree to Sorted Doubly Linked List.
        /// </summary>
        Node_426 first = null;
        Node_426 last = null;

        public Node_426 TreeToDoublyList(Node_426 root)
        {
            if (root == null)
                return null;
            DFS(root);

            last.right = first;
            first.left = last;
            return first;
        }
        public void DFS(Node_426 root)
        {
            if (root == null)
                return;
            //left
            DFS(root.left); 
            //value
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

            //right
            DFS(root.right);
        }
    }
}
