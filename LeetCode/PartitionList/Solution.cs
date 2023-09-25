namespace PartitionList
{
    public class Solution
    {
        public ListNode Partition(ListNode head, int x)
        {
            if (head == null || head.next == null) return head;

            ListNode p = head;
            List<ListNode> lessthanList = new List<ListNode>();
            List<ListNode> largerthanOrEqualList = new List<ListNode>();

            while (p != null)
            {
                if (p.val < x)
                {
                    lessthanList.Add(p);
                }
                else
                {
                    largerthanOrEqualList.Add(p);
                }
                p = p.next;
            }

            if (lessthanList.Any() && lessthanList.Count > 1)
            {
                head = lessthanList[0];
                p = head;
                for (int i = 1; i < lessthanList.Count; i++)
                {
                    p.next = lessthanList[i];
                    p = p.next;
                }
            }
            else if (lessthanList.Count == 1)
            {
                head = lessthanList[0];
                p = head;
            }

            if (largerthanOrEqualList.Any())
            {
                if (p == null)
                {
                    head = largerthanOrEqualList[0];
                    p = head;
                }
                else
                {
                    p.next = largerthanOrEqualList[0];
                    p = p.next;
                }

                for (int i = 1; i < largerthanOrEqualList.Count; i++)
                {
                    p.next = largerthanOrEqualList[i];
                    p = p.next;
                }
                p.next = null;
            }
            else
            {
                if (p != null)
                {
                    p.next = null;
                }
            }

            return head;
        }
    }
}
