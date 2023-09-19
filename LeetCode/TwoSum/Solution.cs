namespace TwoSum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            //int[] result = new int[2];
            //int i = 0;
            //while (i < nums.Length - 1 )
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            result[0] = i;
            //            result[1] = j;

            //            return result;
            //        }
            //    }
            //    i++;
            //}
            
            //return result;

            Dictionary<int, int> map = new Dictionary<int, int>();
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];

                if (!map.ContainsKey(diff))
                {
                    map[nums[i]] = i;
                }
                else
                {
                    result[0] = i;
                    result[1] = map[diff];
                    break;
                }
            }

            return result;
        }
    }
}
