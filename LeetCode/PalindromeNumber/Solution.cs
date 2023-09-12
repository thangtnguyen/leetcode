namespace PalindromeNumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string stringVal = x.ToString();

            return IsSymetric(stringVal);
        }

        private bool IsSymetric(string s)
        {
            return s.Equals(new string(s.Reverse().ToArray()));
        }
    }
}
