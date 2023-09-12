// See https://aka.ms/new-console-template for more information
using BaseballGame;

Console.WriteLine("Hello, World!");

List<int> pointResult = new List<int>();

Solution solution = new Solution();
char[] space = new char[] { ' ' };

string[] ops = Console.ReadLine().Split(space);
int output = solution.CalPoints(ops);
Console.WriteLine(output.ToString());