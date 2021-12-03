using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedianOfTwoSortedArray
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            List<int> merged = new List<int>();
            
            merged.AddRange(nums1);
            merged.AddRange(nums2);
            merged.Sort();

            if (merged.Count == 0)
            {
                return 0;
            }
            else if (merged.Count == 1)
            {
                return merged[0];
            }
            else
            {
                int selectedIndex = merged.Count / 2;
                if (merged.Count % 2 == 0)
                {   
                    return (double)(merged[selectedIndex - 1] + merged[selectedIndex]) / 2;
                }
                else
                {   
                    return (merged[selectedIndex]);
                }
            }
        }
    }
}
