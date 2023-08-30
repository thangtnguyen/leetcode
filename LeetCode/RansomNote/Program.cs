namespace RansomNote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(firstMultipleInput[0]);

            int n = Convert.ToInt32(firstMultipleInput[1]);

            List<string> magazine = Console.ReadLine().TrimEnd().Split(' ').ToList();

            List<string> note = Console.ReadLine().TrimEnd().Split(' ').ToList();

            Result.checkMagazine(magazine, note);
        }
    }
}