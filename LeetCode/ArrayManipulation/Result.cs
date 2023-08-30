using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulation
{
    public class Result
    {
        /*
     * Complete the 'arrayManipulation' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

        public static long arrayManipulation(int n, List<List<int>> queries)
        {
            long[] numList = new long[n];
            
            foreach (var query in queries)
            {
                for (int i = query[0] - 1; i < query[1]; i++)
                {
                    numList[i] += query[2];
                }
            }

            return numList.Max();

        }
    }
}