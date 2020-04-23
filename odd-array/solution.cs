using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if (A.Length == 1)
        {
            return A[0];
        }
        return CountOccurence(A);
    }
    public int CountOccurence(int[] input)
    {
        var groups = from num in input
                     group num by num into g
                     select new { g.Key, Count = g.Count() };

        return groups.Where(x => x.Count % 2 > 0).Select(x => x.Key).FirstOrDefault();
    }
}