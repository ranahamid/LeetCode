using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode_160
    {
        public int val;
        public ListNode_160 next;
        public ListNode_160(int x) { val = x; }
    }
    internal class _160
    {
        #region hashset
        public ListNode_160 GetIntersectionNode(ListNode_160 headA, ListNode_160 headB)
        {

            var bSet = new HashSet<ListNode_160>();
            while (headB != null)
            {
                bSet.Add(headB);
                headB = headB.next;
            }
            while (headA != null)
            {
                if (bSet.Contains(headA))
                    return headA;
                headA = headA.next;
            }
            return null;
        }
        #endregion
        public ListNode_160 GetIntersectionNode_2(ListNode_160 headA, ListNode_160 headB)
        {
            var aHead = headA;
            while (aHead != null)
            {
                var bHead = headB;
                while (bHead != null)
                {
                    if (bHead == aHead)
                        return bHead;
                    bHead = bHead.next;
                }

                aHead = aHead.next;
            }
            return null;
        }
    }
}
