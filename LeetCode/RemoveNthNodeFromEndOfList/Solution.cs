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

        public ListNode RemoveNthFromEnd2(ListNode head, int n)
        {
            ListNode newHead = new ListNode(-1);
            newHead.next = head;
            dfs(head, n + 1);

            return newHead.next;
        }

        private int dfs(ListNode node, int k)
        {
            if (node == null) return 0;
            int index = 1 + dfs(node.next, k);
            if (index == k)
            {
                node.next = node.next.next;
            }

            return index;
        }
    }
}
