// See https://aka.ms/new-console-template for more information
using CourseSchedule;

Console.WriteLine("Hello, World!");
int numCourses = 2;
int[][] prerequisites = new int[1][];
prerequisites[0] = new int[]{ 1, 0};
Solution solution = new Solution();
var result = solution.CanFinish(numCourses, prerequisites);
Console.WriteLine(result);