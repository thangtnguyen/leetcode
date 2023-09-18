using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace ThreeSum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {

            IList<IList<int>> result = new List<IList<int>>();

            int leftIndex = 0, rightIndex = nums.Length - 1;

            while (leftIndex < rightIndex)
            {
                int middleIndex = leftIndex + 1;
                int leftRightTotal = nums[leftIndex] + nums[rightIndex];

                while (middleIndex < rightIndex)
                {                    
                    if (nums[middleIndex] == -leftRightTotal)
                    {
                        List<int> newList = new List<int> { nums[leftIndex], nums[middleIndex], nums[rightIndex] };
                        bool isDuplicated = false;
                        foreach (var item in result)
                        {
                            if (item.All(newList.Contains) && newList.All(item.Contains))
                            {
                                isDuplicated = true;
                                break;
                            }
                        }
                        if (!isDuplicated)
                        {
                            result.Add(newList);
                        }
                    }

                    middleIndex++;
                }
                rightIndex--;
                if (rightIndex == leftIndex)
                {
                    rightIndex = nums.Length - 1;
                    leftIndex++;
                }
            }

            return result;
        }
    }
}
