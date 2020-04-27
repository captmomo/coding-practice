using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int A, int B, int K) {
        var upperDivisions = B/K;
        //A -1 because B/K includes the A;
        var lowerDivisions = (A-1)/K;
        //0 % K == 0 => therefore total increase by 1;
        //range is 0 - 2E9, so if A != 0, no need consider 0%K
        var total = A == 0 
        ? (upperDivisions + 1) 
        : upperDivisions - lowerDivisions;
        
        return total;
    }
}