using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    public class Solution
    {
        public int Reverse(int x)
        {
            var stringVal = new string(Convert.ToString(x).Reverse().ToArray());
            if (x < 0)
            {
                stringVal = "-" + stringVal.Remove(stringVal.Length - 1, 1);
            }
            try
            {
                return Convert.ToInt32(stringVal);
            }
            catch (OverflowException ex)
            {
                return 0;
            }
        }
        
    }
}
