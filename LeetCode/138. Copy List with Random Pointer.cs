using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _138
    {
        /// <summary>
        /// Runtime 157 ms Beats 45.2% Memory 37.9 MB Beats 59.30%
        /// </summary>
        Dictionary<Node, Node> dic = new Dictionary<Node, Node>();
        public Node CopyRandomList(Node head)
        {
            if (head == null)
                return head;
            if (dic.ContainsKey(head))
                return dic[head];
            var node = new Node(head.val);
            dic.TryAdd(head, node);
            node.next = CopyRandomList(head.next);
            node.random = CopyRandomList(head.random);
            return node;
        }
    }
}
