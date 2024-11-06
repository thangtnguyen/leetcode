// See https://aka.ms/new-console-template for more information
using RotateArray;

Console.WriteLine("Hello, World!");

int[] input = new int[] {1, 2,3 ,4, 5, 6, 7};
Solution solution = new Solution();
solution.Rotate(input, 3);

for (int i = 0; i < input.Length; i++)
{
    Console.WriteLine(input[i]);
}
