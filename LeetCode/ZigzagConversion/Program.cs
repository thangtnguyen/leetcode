namespace ZigzagConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string: ");
            var s = Console.ReadLine();
            Console.WriteLine("Number of rows: ");
            var numRows = Console.ReadLine();
            Solution solution = new Solution();
            var output = solution.Convert(s, Convert.ToInt32(numRows));
            Console.WriteLine(output);
        }
    }
}