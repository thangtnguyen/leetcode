// See https://aka.ms/new-console-template for more information
using ReverseInteger;

Console.WriteLine("Input value");
var input = Console.ReadLine();
var valueInput = Convert.ToInt32(input);
Solution solution = new Solution();
var result = solution.Reverse(valueInput);
Console.WriteLine(result);

