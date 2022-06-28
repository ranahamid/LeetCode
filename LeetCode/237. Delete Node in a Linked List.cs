namespace LeetCode
{
     
  public class ListNode_237 {
      public int val;
      public ListNode_237 next;
      public ListNode_237(int x) { val = x; }
  }
  
    public class _237__Delete_Node_in_a_Linked_List
    {
        /// <summary>
        /// Runtime: 113 ms, faster than 58.17% of C# online submissions for Delete Node in a Linked List.
        /// Memory Usage: 37.4 MB, less than 96.79% of C# online submissions for Delete Node in a Linked List.
        /// </summary>
        /// <param name="node"></param>
        public void DeleteNode(ListNode_237 node) {
            node.val=node.next.val;
            node.next=node.next.next;
        
        }
    }
}