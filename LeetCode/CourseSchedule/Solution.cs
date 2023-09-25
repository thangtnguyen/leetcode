using System.Reflection.Metadata;

namespace CourseSchedule
{
    public class Solution
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            if (numCourses <= 0) return false;
            if (numCourses == 1) return true;

            Dictionary<int, List<int>> prerequisiteNodes = new Dictionary<int, List<int>>();
            int[] inDegree = new int[numCourses];
            Queue<int> handlingQueue = new Queue<int>();

            for (int i = 0; i < numCourses; i++)
            {
                prerequisiteNodes[i] = new List<int>();
            }

            foreach(var prerequisite in prerequisites)
            {
                prerequisiteNodes[prerequisite[1]].Add(prerequisite[0]);

                inDegree[prerequisite[0]] += 1;
            }

            for (int i = 0; i < inDegree.Length; i++)
            {
                if (inDegree[i] == 0)
                {
                    handlingQueue.Enqueue(i);
                }
            }

            if (!handlingQueue.Any()) return false;
            int enrolled = 0;
            while (handlingQueue.Any())
            {
                int enrolledCourse = handlingQueue.Dequeue();
                enrolled += 1;
                foreach (var node in prerequisiteNodes[enrolledCourse])
                {
                    if (inDegree[node] > 0)
                    {
                        inDegree[node] -= 1;
                    }
                    if (inDegree[node] == 0) handlingQueue.Enqueue(node);
                }
            }

            return enrolled == numCourses;
        }
    }
}
