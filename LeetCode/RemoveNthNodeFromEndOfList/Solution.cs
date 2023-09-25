namespace RemoveNthNodeFromEndOfList
{
    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null || n <= 0) return null;

            int numNode = 0;
            ListNode p = head;
            while (p != null)
            {
                numNode++;
                p = p.next;
            }

            int numTraverse = numNode - n;

            p = head;
            ListNode prev = null;
            while (p != null && numTraverse > 0)
            {
                prev = p;
                p = p.next;
                numTraverse--;
            }

            if (prev == null)
            {
                head = p.next;
                p = head;
            }
            else
            {
                prev.next = p.next;
                p.next = null;
            }

            return head;
        }
    }
}
