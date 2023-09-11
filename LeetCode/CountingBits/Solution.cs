using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingBits
{
    public class Solution
    {
        public int[] CountBits(int n)
        {
            List<int> resultList = new List<int>();
            for (int i = 0; i <= n; i++)
            {
                resultList.Add(Convert.ToString(i, 2).ToCharArray().Count(c => c == '1'));
            }

            return resultList.ToArray();
        }
    }
}
