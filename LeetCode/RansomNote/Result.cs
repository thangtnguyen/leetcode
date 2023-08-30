namespace RansomNote
{
    internal class Result
    {
        /*
     * Complete the 'checkMagazine' function below.
     *
     * The function accepts following parameters:
     *  1. STRING_ARRAY magazine
     *  2. STRING_ARRAY note
     */

        public static void checkMagazine(List<string> magazine, List<string> note)
        {
            Dictionary<string, long> magazineWords = new Dictionary<string, long>();
            foreach (string word in magazine)
            {
                if (magazineWords.ContainsKey(word))
                {
                    magazineWords[word] += 1;
                }
                else
                {
                    magazineWords[word] = 1;
                }
            }

            foreach (string word in note)
            {
                if (magazineWords.ContainsKey(word))
                {
                    magazineWords[word] -= 1;
                    if (magazineWords[word] < 0)
                    {
                        Console.WriteLine("No");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("No");
                    return;
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
