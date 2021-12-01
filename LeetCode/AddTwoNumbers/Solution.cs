using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    /**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = null;

            var p1 = l1;
            var p2 = l2;
            int nextVal = 0;
            bool isFirstRun = true;
            ListNode temp = null;

            while (p1 != null || p2 != null)
            {
                if (isFirstRun)
                {
                    result = Add(p1, p2, 0, out nextVal);
                    temp = result;
                    isFirstRun = false;
                }
                else
                {
                    temp.next = Add(p1, p2, nextVal, out nextVal);
                    temp = temp.next;
                }

                if (p1 != null)
                {
                    p1 = p1.next;
                }
                

                if (p2 != null)
                {
                    p2 = p2.next;
                }

                if (p1 == null && p2 == null && nextVal != 0)
                {
                    temp.next = Add(p1, p2, nextVal, out nextVal);                    
                }
            }

            return result;
        }

        private ListNode Add(ListNode l1, ListNode l2, int additional, out int nextVal)
        {
            
            var total = 0;
            if (l1 != null && l2 != null)
            {
                total = l1.val + l2.val + additional;
            }
            else if (l1 != null)
            {
                total = l1.val + additional;
            }
            else if (l2 != null)
            {
                total = l2.val + additional;                
            }
            else
            {
                nextVal = 0;
                if (additional == 0)
                {
                    return null;
                }
                else
                {
                    return new ListNode(additional);
                }
            }

            nextVal = total / 10;
            total = total % 10;
            ListNode result = new ListNode(total);
            return result;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
          public ListNode(int val = 0, ListNode next = null)
          {
            this.val = val;
            this.next = next;
          }
    }
}
