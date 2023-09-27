namespace ReorderList
{
    public class Solution
    {
        public void ReorderList(ListNode head)
        {
            if (head == null || head.next == null) return;

            ListNode slow = head, fast = head;
            while(fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode head2 = slow.next;
            slow.next = null;
            ListNode head1 = head;

            head2 = ReverseList(head2);
            ListNode current = new ListNode(-1);
            while (head1 != null)
            {
                ListNode temp = head1.next;
                current.next = head1;
                head1.next = head2;
                current = head2;
                head1 = temp;
                if (head2 != null) head2 = head2.next;
            }
        }

        private ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;

            ListNode current = head;
            ListNode previous = null;

            while (current != null)
            {
                ListNode temp = current.next;
                current.next = previous;
                previous = current;
                current = temp;
            }

            return previous;
        }
    }
}
