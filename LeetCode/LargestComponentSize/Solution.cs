using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestComponentSize
{
    public class Solution
    {
        public int LargestComponentSize(int[] nums)
        {
            if (nums.Count() == 1)
            {
                return 0;
            }
            else
            {
                int result = 0;

                for (int i = 0; i < nums.Count(); i++)
                {
                    int temp = 1;
                    for (int j = i; j < nums.Count() - 1; i++)
                    {
                        if (HasCommonFactor(i, j))
                        {
                            ++temp;
                        }
                    }

                }
                return result;
            }
        }

        private bool HasCommonFactor(int a, int b)
        {
            int middle = (a + b) / 2;
            for (int i = 2; i < middle; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
