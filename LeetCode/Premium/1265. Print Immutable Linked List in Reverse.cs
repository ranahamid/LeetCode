using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    class ImmutableListNode
    {
        ImmutableListNode obj = new ImmutableListNode();
        public void PrintValue()
        {

        } // print the value of this node.
        public ImmutableListNode GetNext()
        {
            return obj;
        }// return the next node.
    }
    internal class _1265
    {
        /// <summary>
        /// Runtime: 197 ms, faster than 53.49% of C# online submissions for Print Immutable Linked List in Reverse.
        /// Memory Usage: 41.1 MB, less than 81.40% of C# online submissions for Print Immutable Linked List in Reverse.
        /// </summary>
        /// <param name="head"></param>
        public void PrintLinkedListInReverse(ImmutableListNode head)
        {
            if (head == null)
                return;
            PrintLinkedListInReverse(head.GetNext());
            head.PrintValue();
        }
    }
}
