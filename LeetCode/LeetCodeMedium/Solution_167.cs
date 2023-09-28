namespace LeetCodeMedium
{
    public class Solution_167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int startIndex = 0;
            int endIndex = numbers.Length - 1;
            int[] result = new int[2];

            while (startIndex <  endIndex)
            {
                int total = numbers[startIndex] + numbers[endIndex];
                if (total == target)
                {
                    result[0] = startIndex + 1;
                    result[1] = endIndex + 1;
                    return result;
                }
                else if (total < target)
                {
                    startIndex++;
                }
                else
                {
                     endIndex--;
                }
            }

            return result;
        }
    }
}