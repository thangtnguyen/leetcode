using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstringWithoutRepeatingCharacters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            else if (s.Length == 1)
            {
                return 1;
            }
            else
            {
                Queue<char> queue = new Queue<char>();
                int result = 0;

                foreach (char c in s)
                {
                    if (queue.Contains(c))
                    {
                        while (queue.Contains(c))
                        {
                            queue.Dequeue();
                        }
                        queue.Enqueue(c);
                    }
                    else
                    {
                        queue.Enqueue(c);
                    }

                    if (result < queue.Count)
                    {
                        result = queue.Count;
                    }
                }

                return result;
            }
        }
    }
}
