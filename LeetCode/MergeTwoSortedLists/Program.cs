// See https://aka.ms/new-console-template for more information
using MergeTwoSortedLists;

Console.WriteLine("Hello, World!");

ListNode list1 = new ListNode(-9, new ListNode(3));
ListNode list2 = new ListNode(5, new ListNode(7));

Solution solution = new Solution();
solution.MergeTwoLists(list1, list2);
