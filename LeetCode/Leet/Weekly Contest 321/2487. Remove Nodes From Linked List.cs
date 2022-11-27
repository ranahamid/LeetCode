using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leet.Weekly_Contest_321
{
    internal class _2487
    {
        public ListNode RemoveNodes(ListNode head)
        {
            var list = new List<int>();
            var headRef = head;
            while (headRef != null)
            {
                list.Add(headRef.val);
                headRef = headRef.next;
            }
            var result = new List<int>();
            result.Add(list[list.Count - 1]);

            for (int i = list.Count - 2; i >= 0; i--)
            {
                if (list[i] >= result.LastOrDefault())
                {
                    result.Add(list[i]);
                }
            }

            result.Reverse();
            Console.WriteLine(String.Join(",", result));
            headRef = head;
            int counter = 0;
            while (headRef != null)
            {
                if (result[counter] != headRef.val)
                {
                    Console.WriteLine("Deleted: " + headRef.val);
                    headRef.val = headRef.next.val;
                    headRef.next = headRef.next.next;
                }
                else
                {
                    Console.WriteLine("Non Deleted: " + headRef.val);
                    counter++;
                    headRef = headRef.next;
                }

            }
            return head;
        }
    }
}
