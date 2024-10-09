// See https://aka.ms/new-console-template for more information
using MergeSortedArray;

Console.WriteLine("88.Merge Sorted Array");

int[] nums1 = { 1, 2, 3, 0, 0, 0 };
int[] nums2 = { 2, 5, 6 };

Solution solution = new Solution();
solution.Merge(nums1, 3, nums2, 3);
Console.WriteLine(nums1);
Console.ReadLine();