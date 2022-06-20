using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    public class ListNode_21
    {
        public int val;
        public ListNode_21 next;
        public ListNode_21(int val = 0, ListNode_21 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _21_Merge_Two_Sorted_Lists
    {

        public void Display()
        {
            //ListNode_21 six = new ListNode_21(4);
            //ListNode_21 five = new ListNode_21(3,six);
            //ListNode_21 list2 = new ListNode_21(1, five);


            //ListNode_21 three = new ListNode_21(3);
            //ListNode_21 two = new ListNode_21(2, three);
            //ListNode_21 list1 = new ListNode_21(1, two);

            ListNode_21 six = new ListNode_21(4);
            ListNode_21 five = new ListNode_21(2, six);
            ListNode_21 list2 = new ListNode_21(1, five);


            ListNode_21 three = new ListNode_21(3);
            ListNode_21 two = new ListNode_21(2, three);
            ListNode_21 list1 = new ListNode_21(5);

            Console.Write(MergeTwoLists(list2, list1));
        }

        /// <summary>
        /// Runtime: 133 ms, faster than 31.02% of C# online submissions for Merge Two Sorted Lists.
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static ListNode_21 MergeTwoLists(ListNode_21 list1, ListNode_21 list2)
        {
            ListNode_21 head = new ListNode_21(0);
            var tail = head;
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            while (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    tail.next = new ListNode_21(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    tail.next = new ListNode_21(list2.val);
                    list2 = list2.next;
                }
                tail = tail.next;
            }
            tail.next = list1 != null ? list1 : list2;
            return head.next;
        }

        /// <summary>
        /// Runtime: 80 ms, faster than 98.47% of C# online submissions for Merge Two Sorted Lists.
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <returns></returns>
        public static ListNode_21 MergeTwoLists_2(ListNode_21 list1, ListNode_21 list2)
        {
            ListNode_21 head = new ListNode_21(0);
          
            if (list1 == null) return list2;
            if (list2 == null) return list1;


            if (list1.val <= list2.val)
            {
                list1.next = MergeTwoLists(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists(list1, list2.next);
                return list2;
            }
        }
    }
}
