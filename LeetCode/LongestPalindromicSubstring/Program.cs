namespace LongestPalindromicSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            var solution = new Solution();
            string result =  solution.LongestPalindrome(inputString);

            Console.WriteLine(result);

        }
    }
}