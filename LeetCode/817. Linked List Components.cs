using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode_817
    {
        public int val;
        public ListNode_817 next;
        public ListNode_817(int val = 0, ListNode_817 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _817
    {
        /// <summary>
        /// Runtime: 233 ms, faster than 18.18% of C# online submissions for Linked List Components.
       /// Memory Usage: 41.7 MB, less than 77.27% of C# online submissions for Linked List Components.
        /// </summary>
        /// <param name="head"></param>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int NumComponents(ListNode_817 head, int[] nums)
        {
            int counter = 0;
            var set = new HashSet<int>(nums);
            while (head != null && set.Any())
            {
                if (set.Contains(head.val))
                {
                    counter++;
                    while (head != null && set.Contains(head.val))
                    {
                        set.Remove(head.val);
                        if (head != null)
                        {
                            head = head.next;
                        }
                    }
                }
                if (head != null)
                {
                    head = head.next;
                }
            }
            return counter;
        }
    }
}
