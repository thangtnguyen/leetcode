namespace LengthOfLastWord
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            string endTrimString = s.TrimEnd();

            int index = endTrimString.Length - 1;
            int result = 0;
            while (index >= 0 && endTrimString[index] != ' ')
            {
                index--;
                result++;
            }

            return result;
        }
    }
}
