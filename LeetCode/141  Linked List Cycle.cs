using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode_141
    {
        public int val;
        public ListNode_141 next;
        public ListNode_141(int x)
        {
            val = x;
            next = null;
        }
    }
    internal class _141__Linked_List_Cycle
    {   /// <summary>
        /// Runtime: 141 ms, faster than 49.27% of C# online submissions for Linked List Cycle.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static bool HasCycle(ListNode_141 head)
        {
            var fastNode = head;
            var slowNode = head;
            while (fastNode != null)
            {
                fastNode = fastNode.next;
                if (fastNode == null)
                    return false;

                fastNode = fastNode.next;
                if (fastNode == null)
                    return false;

                slowNode = slowNode.next;
                if (slowNode == fastNode)
                    return true;

            }
            return false;
        }
    }
}
