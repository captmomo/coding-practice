using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int K, int[] A) {
        if(A.Length == 0)
        {
            return 0;
        }
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int counter = 0;
        int currentTotal = 0;
        for(int i = 0; i < A.Length; i ++)
        {
            if(A[i] >= K)
            {
                counter += 1;
                currentTotal = 0;
                continue;
            }
            
            //if this is a new rope
            //continue
            if(currentTotal == 0)
            {
                currentTotal = A[i];
                continue;
            }
            //if there's a rope shorter than K
            //see if can tie
            currentTotal += A[i];
            if(currentTotal >= K)
            {
                counter += 1;
                currentTotal = 0;
            }
        }
        return counter;
    }
}