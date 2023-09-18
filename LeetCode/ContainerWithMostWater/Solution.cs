namespace ContainerWithMostWater
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int leftIndex = 0, rightIndex = height.Length - 1;
            int result = 0;
            
            while (rightIndex > leftIndex)
            {
                int area = Math.Min(height[rightIndex], height[leftIndex]) * (rightIndex - leftIndex);
                result = Math.Max(result, area);

                if (height[leftIndex] <= height[rightIndex]) 
                {
                    int temp = height[leftIndex];
                    do
                        leftIndex++;
                    while (leftIndex < rightIndex && height[leftIndex] <= temp);
                }
                else
                {
                    int temp = height[rightIndex];
                    do
                        rightIndex--;
                    while (leftIndex < rightIndex && height[rightIndex] <= temp);
                }
            }

            return result;
        }
    }
}
