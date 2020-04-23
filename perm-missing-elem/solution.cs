using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        if (A.Length == 0)
        {
            return 1;
            
        }
        if (A.Length == 1)
        {
            return A[0] == 1 ? 2 : 1;
            
        }
        Array.Sort(A);
        //if all numbers are there; last num is missing
        int missingNum = A.Length + 1;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i] != i + 1)
            {
                missingNum = i + 1;
                break;
                
            };
            
        }
        return missingNum;
    }
}