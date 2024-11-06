namespace RotateArray
{
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {

            if (nums != null && nums.Length > 1)
            {
                if (nums.Length > k)
                {
                    int[] firstGroup = new int[nums.Length - k];
                    int[] secondGroup = new int[k];


                    for (int i = nums.Length - k, index = 0; i < nums.Length; i++, index++)
                    {
                        secondGroup[index] = nums[i];
                    }

                    for (int i = 0; i < nums.Length - k; i++)
                    {
                        firstGroup[i] = nums[i];
                    }

                    for (int i = 0; i < nums.Length; i++)
                    {
                        if (i < k)
                        {
                            nums[i] = secondGroup[i];
                        }
                        else
                        {
                            nums[i] = firstGroup[i - k];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < k; i++)
                    {
                        int lastVal = nums[nums.Length - 1];
                        int prevTemp = nums[0];

                        for (int j = 1; j < nums.Length; j++)
                        {
                            int currTemp = nums[j];
                            nums[j] = prevTemp;
                            prevTemp = currTemp;
                        }
                        nums[0] = lastVal;
                    }
                }
            }
        }
    }
}
