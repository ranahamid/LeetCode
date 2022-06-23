using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode_1290
    {
        public int val;
        public ListNode_1290 next;
        public ListNode_1290(int val = 0, ListNode_1290 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _1290_Convert_Binary_Number_in_a_Linked_List_to_Integer
    {
        public void display()
        {
            ListNode_1290 fifteen = new ListNode_1290(0);
            ListNode_1290 fourtenn = new ListNode_1290(0, fifteen);
            ListNode_1290 thirteen = new ListNode_1290(0, fourtenn);
            ListNode_1290 twelve = new ListNode_1290(0, thirteen);
            ListNode_1290 eleven = new ListNode_1290(0, twelve);
            ListNode_1290 ten = new ListNode_1290(0, eleven);
            ListNode_1290 nine = new ListNode_1290(1, ten);
            ListNode_1290 eight = new ListNode_1290(1, nine);
            ListNode_1290 seven = new ListNode_1290(1, eight);
            ListNode_1290 six = new ListNode_1290(0, seven);
            ListNode_1290 five = new ListNode_1290(0, six);
            ListNode_1290 four = new ListNode_1290(1, five);
            ListNode_1290 three = new ListNode_1290(0, four);
            ListNode_1290 two = new ListNode_1290(0, three);
            ListNode_1290 list1 = new ListNode_1290(1, two);


        }
        /// <summary>
        /// Runtime: 117 ms, faster than 46.24% of C# online submissions for Convert Binary Number in a Linked List to Integer.
        /// Memory Usage: 37.1 MB, less than 32.33% of C# online submissions for Convert Binary Number in a Linked List to Integer.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static int GetDecimalValue(ListNode_1290 head)
        {

            StringBuilder sb = new StringBuilder();
            while (head != null)
            {
                sb.Insert(0, head.val);
                head = head.next;
            }
            var revBin = sb.ToString().ToCharArray();
            var r = revBin.Reverse().ToArray();
            var data = new string(r);
            var result = Convert.ToInt32(data, 2);
            return result;
        }

    }
}
