using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        //if all -ve return 1
        bool gotPositives = A.Any(x => x > 0);
        if(!gotPositives)
        {
            return 1;
        }
        var distinctNums = A.Distinct().ToArray();
        //sort by asc
        Array.Sort(distinctNums);
        //find maxvalue;
        int maxValue = distinctNums.Max();
        //find minValue;
        int minValue = distinctNums.Min();

        var tracker = distinctNums.ToDictionary(i => i, v => false);
        bool temp;
        for (int i = 1; i < maxValue + 1; i++)
        {
            if(!tracker.TryGetValue(i, out temp))
            {
                return i;
            }
        }
        //if didn't return in loop, means it's a edge case
        //i.e. int in range(1, maxValue) are present;
        return maxValue +1;

    }
}