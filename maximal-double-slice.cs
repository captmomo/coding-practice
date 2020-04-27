using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        int N = A.Length;
        
        int[] trackerF = getMaxEndForward(A);
        int[] trackerB = getMaxEndBackward(A);
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int maxDoubleSlice = 0;
        for(int i = 0; i < A.Length - 2; i++) 
        {
            maxDoubleSlice = Math.Max(maxDoubleSlice, trackerF[i] + trackerB[i+2]);
        }
        return maxDoubleSlice;
    }
    
    private int[] getMaxEndForward(int[] input)
    {
        int maxEnd = 0;
        int maxSlice = 0;
        int lastIndex = 0;
        int[] result = new int[input.Length];
        //max X = Y - 1
        //slice 1
        // 1 <= a <= Y -1
        //MAX Y = N - 2
        // 1 <= a <= N - 3
        for(int i = 1; i < input.Length - 2; i++)
        {
            maxEnd = Math.Max(0, maxEnd + input[i]);
            result[i] = maxEnd;
        }
        return result;
    }
    
    private int[] getMaxEndBackward(int[] input)
    {
        int maxEnd = 0;
        int maxSlice = 0;
        int lastIndex = 0;
        int[] result = new int[input.Length];
        //slice 2
        //max Y = Z - 1
        // 3 <= b <= Z-1
        //Max Z = N - 1
        // 3 <= b <= N -2
        for(int i = input.Length -2; i > 0; i--)
        {
            maxEnd = Math.Max(0, maxEnd + input[i]);
            result[i] = maxEnd;
        }
        return result;
    }
}