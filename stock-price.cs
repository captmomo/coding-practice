using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int maxSlice = getMaxSlice(A);
        if(maxSlice < 0)
        {
            return 0;
        }
        return maxSlice;
    }
    
    private int getMaxSlice(int[] input)
    {
        int maxEnd = 0;
        int maxSlice = 0;
        for(int i = 0; i < input.Length; i++)
        {
            for(int j = i + 1; j < input.Length; j++)
            {
                maxEnd = input[j] - input[i];
                maxSlice = Math.Max(maxEnd, maxSlice);
            }
        }
        return maxSlice;
    }
}

using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        //get biggest from the back
        if(!A.Any())
        {
            return 0;
        }
        int max = 0;
        int candidate = 0;
        int maxIndex = 0;
        int maxProfit = -int.MaxValue;
        for(int i = A.Length -1; i > 0; i--)
        {
            candidate = A[i];
            if(candidate > max)
            {
                max = candidate;
                maxIndex = i;
                continue;
            }
            else
            {
                maxProfit = Math.Max(maxProfit, max - candidate);
            }
        }
}