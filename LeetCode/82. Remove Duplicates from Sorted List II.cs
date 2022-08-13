using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode_82
    {
        public int val;
        public ListNode_82 next;
        public ListNode_82(int val = 0, ListNode_82 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _82
    {
        /// <summary>
        /// Runtime: 177 ms, faster than 6.91% of C# online submissions for Remove Duplicates from Sorted List II.
        /// Memory Usage: 37.9 MB, less than 79.79% of C# online submissions for Remove Duplicates from Sorted List II.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode_82 DeleteDuplicates(ListNode_82 head)
        {
            if (head == null)
                return null;
            var result = new ListNode_82(-1, head);
            var temp = result;
             
            while (head != null)
                {
                    if (head.next != null && head.val == head.next.val)
                    {
                        while (head.next != null && head.val == head.next.val)
                        {
                            head = head.next;
                        }
                        temp.next = head.next;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                    head = head.next;
                   
                }
          
            return result.next;
        }
    }
}
