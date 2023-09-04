using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoStrings
{
    internal class Result
    {
        /*
         * Complete the 'twoStrings' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts following parameters:
         *  1. STRING s1
         *  2. STRING s2
         */

        public static string twoStrings(string s1, string s2)
        {
            if (s1.Contains(s2) || s2.Contains(s1))
            {
                return "YES";
            }

            if (s1.Length < s2.Length)
            {
                foreach (var item in s1)
                {
                    if (s2.Contains(item))
                    {
                        return "YES";
                    }
                }
            }
            else
            {
                foreach (var item in s2)
                {
                    if (s1.Contains(item))
                    {
                        return "YES";
                    }
                }
            }
            

            return "NO";
        }
    }
}
