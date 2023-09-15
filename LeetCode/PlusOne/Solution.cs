using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOne
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            int index = digits.Length - 1;
            List<int> result = new List<int>();
            int rememberOne = 1;

            while (index >= 0)
            {
                if (index == 0)
                {
                    int val = digits[index] + rememberOne;
                    if (val >= 10)
                    {
                        result.Insert(0, val % 10);
                        result.Insert(0, 1);
                    }
                    else
                    {
                        result.Insert(0, val);
                    }
                }
                else if (index == digits.Length - 1)
                {
                    int val = digits[index] + 1;
                    if (val >= 10)
                    {
                        result.Insert(0, val % 10);
                        rememberOne = 1;
                    }
                    else
                    {
                        result.Insert(0, val);
                        rememberOne = 0;
                    }
                }
                else
                {
                    int val = digits[index] + rememberOne;
                    if (val >= 10)
                    {
                        result.Insert(0, val % 10);
                        rememberOne = 1;
                    }
                    else
                    {
                        result.Insert(0, val);
                        rememberOne = 0;
                    }
                }
                --index;
            }

            return result.ToArray();
        }
    }
}
