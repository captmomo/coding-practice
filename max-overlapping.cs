using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        if(A.Length == 0 || B.Length ==0) 
        {
            return 0;
        }
        int result = 0;
        //A[I] ≤ A[J] ≤ B[I] or A[J] ≤ A[I] ≤ B[J].
        int end = 0;
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] > B[end])
            {
                    result += 1;
                    end = i;
                
            }
            
        }
        return result + 1;
        
    }
}