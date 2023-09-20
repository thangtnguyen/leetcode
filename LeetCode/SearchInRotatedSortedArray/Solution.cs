namespace SearchInRotatedSortedArray
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 1 && nums[0] == target)
            {
                return 0;
            }

            int leftIndex = 0, rightIndex = nums.Length - 1;
            while (leftIndex <= rightIndex)
            {
                int middleIndex = leftIndex + (rightIndex - leftIndex) / 2;
                if (nums[middleIndex] == target) { return middleIndex; }
                if (nums[leftIndex] <= nums[middleIndex]) 
                { 
                    if (nums[leftIndex] <= target && target < nums[middleIndex])
                    {
                        rightIndex = middleIndex - 1;
                    }
                    else
                    {
                        leftIndex = middleIndex + 1;
                    }
                }
                else
                {
                    if (nums[middleIndex] < target && target <= nums[rightIndex]) 
                    {
                        leftIndex = middleIndex + 1;
                    }
                    else
                    {
                        rightIndex = middleIndex - 1;
                    }
                }

            }

            return -1;
        }
    }
}
