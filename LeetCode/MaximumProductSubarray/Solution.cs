namespace MaximumProductSubarray
{
    public class Solution
    {
        public int MaxProduct(int[] nums)
        {
            int min = 1, max = 1, result = max;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    min = 1;
                    max = 1;
                    if (i == 0)
                    {
                        result = nums[i];
                    }
                    else
                    {
                        result = Math.Max(result, nums[i]);
                    }
                }
                else
                {
                    int tempMin = Math.Min(min * nums[i], max * nums[i]);
                    int tempMax = Math.Max(min * nums[i], max * nums[i]);
                    min = Math.Min(nums[i], tempMin);
                    max = Math.Max(nums[i], tempMax);
                    if (i == 0)
                    {
                        result = max;
                    }
                    else
                    {
                        result = Math.Max(max, result);
                    }

                }
            }

            return result;
        }
    }
}
