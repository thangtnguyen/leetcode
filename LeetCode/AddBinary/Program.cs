// See https://aka.ms/new-console-template for more information
using AddBinary;

Console.WriteLine("Hello, World!");
string a = "1010";// "10100000100100110110010000010101111011011001101110111111111101000000101111001110001111100001101";
string b = "1011"; // "110101001011101110001111100110001010100001101011101010000011011011001011101111001100000011011110011";

Solution solution = new Solution();
var result = solution.AddBinary(a, b);
Console.Write(result);
