using System.Text;

namespace LongestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            StringBuilder result = new StringBuilder();
            //get the first item
            string? firstItem = strs.FirstOrDefault();
            if (!string.IsNullOrEmpty(firstItem))
            {
                
                foreach (char c in firstItem)
                {
                    result.Append(c);
                    if (!strs.All(p => p.StartsWith(result.ToString())))
                    {
                        result.Remove(result.Length - 1, 1);
                        break;
                    }
                }
            }

            return result.ToString();
        }
    }
}
