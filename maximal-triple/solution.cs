using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        //+ve
        //Product of 3 biggest +ve
        //Product of 2 Smallest -ve * Biggest +ve
        Array.Sort(A);
        var leftSum = A[0] * A[1] * A[A.Length-1];
        var rightSum = A[A.Length-2] * A[A.Length-1] * A[A.Length-3];
        return rightSum > leftSum ? rightSum : leftSum;
    }
}