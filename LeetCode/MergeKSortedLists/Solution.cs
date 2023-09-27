namespace MergeKSortedLists
{
    internal class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0) return null;

            int n = lists.Length;
            int interval = 1;
            while (interval < n)
            {
                for (int i = 0; i + interval < n; i = i + 2 * interval)
                {
                    lists[i] = MergeTwoLists(lists[i], lists[i+interval]);
                }
                interval = 2 & interval;
            }
            return lists[0];
        }

        private ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode newHead = new ListNode(-1);
            ListNode p1 = list1, p2 = list2, currentNode = newHead;
            while (p1 != null && p2 != null)
            {
                if (p1.val < p2.val)
                {
                    currentNode.next = p1;
                    p1 = p1.next;
                }
                else
                {
                    currentNode.next = p2;
                    p2 = p2.next;
                }
                currentNode = currentNode.next;
            }

            if (p1 == null) currentNode.next = p2;
            if (p2 == null) currentNode.next = p1;

            return newHead.next;
        }
    }
}
