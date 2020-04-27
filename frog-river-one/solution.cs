using System;
using System.Linq;

class Solution {
    public int solution(int X, int[] A) {
    // write your code in C# 6.0 with .NET 4.5 (Mono)
    int answer = 0;
    var distinctCount = A.Distinct().Count();
    int[] tracker = new int[X + 1];

    if(distinctCount < X)
    {
        return -1; 
    }
    int counter = 0;
    for(int i = 0; i < A.Length; i++)
    {
        int current = A[i];
        if(tracker[current] == 0)
        {
            tracker[current] = 1;
            counter += 1;
        }
        if(counter == X)
        {
            return i;
        }
    }
    return answer;  
    } 
}