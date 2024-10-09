namespace MergeSortedArray
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0)
            {
                for (int i = 0; i < nums2.Length; i++)
                {
                    nums1[i] = nums2[i];
                }
            }
            else if (n != 0)
            {
                int[] temp = new int[m + n];
                int index = 0;
                int i1 = 0, i2 = 0;
                while (i1 < m && i2 < n)
                {
                    if (nums1[i1] <= nums2[i2])
                    {
                        temp[index] = nums1[i1];
                        index++;
                        i1++;
                    }
                    else
                    {
                        temp[index] = nums2[i2];
                        index++;
                        i2++;
                    }

                    if (i1 == m)
                    {
                        while (i2 < n)
                        {
                            temp[index] = nums2[i2];
                            index++;
                            i2++;
                        }
                    }

                    if (i2 == n)
                    {
                        while (i1 < m)
                        {
                            temp[index] = nums1[i1];
                            index++;
                            i1++;
                        }
                    }
                }

                for (int i = 0; i < m+n; i++)
                {
                    nums1[i] = temp[i];
                }
            }
        }
    }
}
