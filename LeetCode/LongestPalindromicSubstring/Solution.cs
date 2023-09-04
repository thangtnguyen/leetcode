using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestPalindromicSubstring
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return string.Empty;
            }
            else
            {
                long longestLength = 0;
                string longestString = string.Empty;
                if (s.Length == 1)
                {
                    return s;
                }
                else
                {
                    for (int i = 0; i < s.Length - 1; i++)
                    {
                        for (int j = s.Length - 1; j > i; j--)
                        {
                            var subString = s.Substring(i, j - i + 1);
                            if (subString.Length < longestLength)
                            {
                                break;
                            }

                            if (s[j] == s[i])
                            {
                                if (IsSymetric(subString) && longestLength < subString.Length)
                                {
                                    longestLength = subString.Length;
                                    longestString = subString;
                                }
                            }
                        }
                    }
                }

                if (longestString == string.Empty)
                {
                    return s.Substring(0, 1);
                }
                else
                {
                    return longestString;
                }
            }
        }

        private bool IsSymetric(string s)
        {
            return s.Equals(new string(s.Reverse().ToArray()));
        }
    }
}
