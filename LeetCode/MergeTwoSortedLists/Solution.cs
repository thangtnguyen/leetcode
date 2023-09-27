using System.Net.WebSockets;
using System.Security;

namespace MergeTwoSortedLists
{
    public class Solution
    {
        //public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        //{
        //    var l1 = list1;
        //    var l2 = list2;
        //    if (l1 == null && l2 != null)
        //    {
        //        return l2;
        //    }
        //    else if (l2 == null && l1 != null) 
        //    {
        //        return l1;
        //    }
        //    else if (l1 == null && l2 == null)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        ListNode result = null;
        //        ListNode p = null;
        //        bool firstRun = true;
        //        while (l1 != null && l2 != null)
        //        {
        //            ListNode temp;
        //            if (l1.val < l2.val)
        //            {
        //                temp = l1.next;
        //                if (firstRun)
        //                {
        //                    result = l1;
        //                    p = result;
        //                    firstRun = false;
        //                }
        //                else
        //                {
        //                    p.next = l1;
        //                    p = p.next;
        //                }
        //                if (temp == null)
        //                {
        //                    l1.next = l2;
        //                }
                        
        //                l1 = temp;
        //            }
        //            else
        //            {
        //                temp = l2.next;
        //                if (firstRun)
        //                {
        //                    result = l2;
        //                    p = result;
        //                    firstRun = false;
        //                }
        //                else
        //                {
        //                    p.next = l2;
        //                    p = p.next;
        //                }

        //                if (temp == null)
        //                {
        //                    l2.next = l1;
        //                }                        
        //                l2 = temp;
        //            }                    
        //        }
        //        return result;
        //    }
        //}

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
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
