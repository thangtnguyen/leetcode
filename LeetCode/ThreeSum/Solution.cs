namespace ThreeSum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {

            IList<IList<int>> result = new List<IList<int>>();
            if (nums == null || nums.Length < 3) return result;

            nums = nums.OrderBy(x => x).ToArray();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i != 0 && nums[i] == nums[i - 1]) continue;
                int sum = 0 - nums[i];
                int start = i + 1;
                int end = nums.Length - 1;
                while (start < end)
                {
                    if (nums[start] + nums[end] == sum)
                    {
                        List<int> newList = new List<int> { nums[i], nums[start], nums[end] };
                        result.Add(newList);
                        start++;
                        end--;
                        while (start < nums.Length && nums[start] == nums[start-1]) start++;
                        while (end >= 0 && nums[end] == nums[end + 1]) end--; 
                    }
                    else if (nums[start] + nums[end]  > sum)
                    {
                        end--;
                    }
                    else 
                    {
                        start++;
                    }
                }
            }

            return result;
        }
    }
}
