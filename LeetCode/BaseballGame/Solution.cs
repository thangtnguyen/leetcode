using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    public class Solution
    {
        public int CalPoints(string[] ops)
        {
            List<int> pointResult = new List<int>();

            foreach (string op in ops)
            {
                int point;
                if (int.TryParse(op, out point))
                {
                    pointResult.Add(point);
                }
                else if (op.Equals("C"))
                {
                    if (pointResult.Count > 0)
                    {
                        pointResult.RemoveRange(pointResult.Count - 1, 1);
                    }
                }
                else if (op.Equals("D"))
                {
                    if (pointResult.Count > 0)
                    {
                        pointResult.Add(pointResult[pointResult.Count - 1] * 2);
                    }
                }
                else
                {
                    if (pointResult.Count >= 2)
                    {
                        pointResult.Add(pointResult[pointResult.Count - 1] + pointResult[pointResult.Count - 2]);
                    }
                }
            }

            return pointResult.Sum();
        }
    }
}
