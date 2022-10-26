using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    public class Node
    {
        public int val;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
            next = null;
        }

        public Node(int _val, Node _next)
        {
            val = _val;
            next = _next;
        }
    }
    internal class _708
    {
        public Node Insert(Node head, int insertVal)
        {
            if (head == null)
            {
                var node = new Node(insertVal, null);
                node.next = node;
                return node;
            }
            var prev = head;
            var current = head.next;
            var isInsert = false;
            do
            {

                if (current.val >= insertVal && insertVal >= prev.val)
                {
                    isInsert = true;
                }
                else if (prev.val > current.val)
                {
                    if (current.val >= insertVal || insertVal >= prev.val)
                    {
                        isInsert = true;
                    }
                }
                if (isInsert)
                {
                    prev.next = new Node(insertVal, current);
                    return head;
                }

                prev = current;
                current = current.next;

            } while (prev != head);//while (current != head);

            prev.next = new Node(insertVal, current);
            return head;
        }
    }
}
