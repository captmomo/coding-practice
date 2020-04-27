using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    //A, C, G and T have impact factors of 1, 2, 3 and 4, respectively
    public Dictionary<char, int> ImpactFactors =
    new Dictionary<char, int>()
    {
        { 'A', 1}, {'C', 2}, {'G', 3},{'T', 4}
    };
    public int[] solution(string S, int[] P, int[] Q)
    {
        int[] tracker = new int[P.Length];

        if (S.Distinct().Count() == 1)
        {
            for (int j = 0; j < tracker.Length; j++)
            {
                tracker[j] = ImpactFactors[S[0]];
            }
            return tracker;
        }
        //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays
        int[][] prefixSums = new int[3][];
        prefixSums[0] = new int[S.Length + 1];
        prefixSums[1] = new int[S.Length + 1];
        prefixSums[2] = new int[S.Length + 1];
        prefix_sums(S, prefixSums);
        int lowerBound = 0;
        int upperBound = 0;
        for (int i = 0; i < P.Length; i++)
        {
            //positions start from 0
            //therefore position 0 = index 0
            lowerBound = P[i];
            upperBound = Q[i] + 1;
            //range(X, Y) => P[Y + 1] - P[X]
            if (prefixSums[0][upperBound] - prefixSums[0][lowerBound] > 0)
            {
                tracker[i] = 1;
            }
            else if (prefixSums[1][upperBound] - prefixSums[1][lowerBound] > 0)
            {
                tracker[i] = 2;
            }
            else if (prefixSums[2][upperBound] - prefixSums[2][lowerBound] > 0)
            {
                tracker[i] = 3;
            }
            else
            {
                tracker[i] = 4;
            }
        }
        return tracker;
    }
    private void prefix_sums(string input, int[][] sums)
    {
        int A = 0;
        int G = 0;
        int C = 0;
        for (int i = 0; i < input.Length; i++)
        {
            A = 0;
            G = 0;
            C = 0;
            switch (input[i])
            {
                case 'A':
                    A = 1;
                    break;
                case 'G':
                    G = 1;
                    break;
                case 'C':
                    C = 1;
                    break;
                default:
                    break;
            }
            sums[0][i + 1] = sums[0][i] + A;
            sums[1][i + 1] = sums[1][i] + C;
            sums[2][i + 1] = sums[2][i] + G;
        }
    }
}