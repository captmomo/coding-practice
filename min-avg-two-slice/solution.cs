using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        //Q < N
        //MAX Q = N -1
        //P < Q
        //MAX P = N - 2;
        //1,2,3
        //Q = 2;
        //P = 1?
        //P >= 0
        // p can never = q
        int N = A.Length;
        int difference = 0;
        var numArray = prefix_sums(A);
        double smallest = double.MaxValue;
        double current = 0;
        double total = 0;
        int smallestIndex = int.MaxValue;
        //a_o = p_1
        //N -1 because N - 2 + 1
        for(int i = 0; i < (N-1); i++)
        {
            //N because N - 1 + 1
            for(int j = i + 1; j < Math.Min(i + 3, N); j++)
            {
                difference = j - i + 1;
                total = count_total(numArray, i, j);
                current = total/difference;
                if(current <= smallest)
                {
                    if(current < smallest)
                    {
                        smallestIndex = i;
                    }
                    smallest = current;
                }
            }
        }

        return smallestIndex;
        // write your code in C# 6.0 with .NET 4.5 (Mono)
    }
    private int[] prefix_sums(int[] A){
        int N = A.Length;
        int[] P = new int[N+1];
        for(int i = 1; i < N + 1; i++)
        {
            P[i] = P[i -1] + A[i -1];
        }
        return P;
    }
    private double count_total(int[] P, int x, int y){
        return P[y + 1] - P[x];
    }
}