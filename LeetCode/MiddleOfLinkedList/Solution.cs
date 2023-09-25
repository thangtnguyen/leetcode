namespace MiddleOfLinkedList
{
    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode slowPointer = head, fastPointer = head;

            while (slowPointer != null && fastPointer != null && fastPointer.next != null) {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }

            return slowPointer;
        }
    }
}
