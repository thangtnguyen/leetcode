namespace FindMinimumInRotatedSortedArray
{
    public class Solution
    {
        public int FindMin(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            if (nums.Length == 2) return Math.Min(nums[0], nums[1]);
            if (nums[0] < nums[nums.Length - 1]) return nums[0];

            int leftIndex = 0, rightIndex = nums.Length - 1;


            while (leftIndex <= rightIndex)
            {
                int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                if (nums[middleIndex] > nums[middleIndex + 1]) { return nums[middleIndex + 1]; }
                if (nums[middleIndex - 1] > nums[middleIndex]) { return nums[middleIndex]; }

                if (nums[leftIndex] < nums[middleIndex])
                {
                    leftIndex = middleIndex + 1;
                }
                else
                {
                    rightIndex = middleIndex - 1;
                }
            }

            return 0;
        }
    }
}
