using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode_2181
    {
        public int val;
        public ListNode_2181 next;
        public ListNode_2181(int val = 0, ListNode_2181 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _2181
    {
        /// <summary>
        /// Runtime: 856 ms, faster than 5.69% of C# online submissions for Merge Nodes in Between Zeros.
        /// Memory Usage: 61.3 MB, less than 39.84% of C# online submissions for Merge Nodes in Between Zeros.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode_2181 MergeNodes(ListNode_2181 head)
        {
            var result = new ListNode_2181();
            var data = result;
            var sum = 0;
            while (head != null)
            {
                if (head.val != 0)
                {
                    sum = sum + head.val;
                }
                else if (head.val == 0)
                {
                    if (sum != 0)
                    {
                        // data.val = sum;
                        data.next = new ListNode_2181();

                        data = data.next;
                        data.val = sum;
                        sum = 0;
                    }
                }
                head = head.next;
            }
            return result.next;
        }

    }
}
