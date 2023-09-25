namespace LinkedListCircle
{
    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            ListNode slowPointer = head, fastPointer = head;
            while (slowPointer != null && fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
                if (slowPointer == fastPointer) return true;
            }

            return false;
        }
    }
}
