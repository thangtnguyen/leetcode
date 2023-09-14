// See https://aka.ms/new-console-template for more information
using RemoveDuplidatesFromSortedArray;

Console.WriteLine("Hello, World!");

int[] nums = new int[] { 1, 1, 2 };

Solution solution = new Solution();
solution.RemoveDuplicates(nums);
foreach (int i in nums)
{
    Console.WriteLine(i);
}