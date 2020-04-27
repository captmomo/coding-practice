using System.Linq;
using System;
class Solution {
    public int solution(int[] A) {
        
        return getMaxSlice(A);
    }
    
    private int getMaxSlice(int[] A)
    {
        long maxEnd = 0;
        long maxSlice = A[0];
        
        foreach(int num in A)
        {
            maxEnd = Math.Max(num, maxEnd + num);
            maxSlice = Math.Max(maxSlice, maxEnd);
        }
        return (int)maxSlice;
    }
}