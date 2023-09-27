// See https://aka.ms/new-console-template for more information
using MergeKSortedLists;

Console.WriteLine("Hello, World!");

ListNode[] lists = new ListNode[3];
ListNode p = new ListNode(1);
lists[0] = p;
p.next = new ListNode(4);
p = p.next;
p.next = new ListNode(5);

p = new ListNode(1);
lists[1] = p;
p.next = new ListNode(3);
p = p.next;
p.next = new ListNode(4);

p = new ListNode(2);
lists[2] = p;
p.next = new ListNode(6);

Solution solution = new Solution();
ListNode node = solution.MergeKLists(lists);
