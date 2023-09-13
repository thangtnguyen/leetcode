using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            {
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }

            return s.Length == 0;
        }
    }
}
