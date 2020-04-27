using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        //given N counters
        int[] counters = new int[N];
        //according to instruction index starts from 1
        //A[K] = X => increase counters[X-1] by 1
        //A[K] == N + 1 => find max and set all counters to Max
        int currentMax = 0;
        int baseMax = 0;
        for(int i = 0; i < A.Length; i++ )
        {
            if(A[i] != N + 1)
            {
                currentMax = Math.Max(currentMax, Increase(counters, A[i]));
            }
            else
            {
                baseMax = currentMax;
            }
        }
        for(int i = 0; i< counters.Length; i++)
        {
            counters[i] = Math.Max(counters[i], baseMax);
        }
        return counters;
    }
    
    private int Increase(int[] input, int X)
    {
        input[X-1] += 1;
        return input[X-1];
    }   
}

// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int[] solution(int N, int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        
        //given N counters
        int[] counters = new int[N];
        //according to instruction index starts from 1
        //A[K] = X => increase counters[X-1] by 1
        //A[K] == N + 1 => find max and set all counters to Max
        int currentMax = 0;
        int baseMax = 0;
        for(int i = 0; i < A.Length; i++ )
        {
            if(A[i] != N + 1)
            {
                currentMax = Math.Max(currentMax, Increase(counters, A[i], baseMax));
            }
            else
            {
                baseMax = currentMax;
            }
        }
        for(int i = 0; i < counters.Length; i++)
        {
            counters[i] = Math.Max(counters[i], baseMax);
        }
        return counters;
    }
    
    private int Increase(int[] input, int X, int baseMax)
    {
        input[X-1] = Math.Max(baseMax + 1, input[X-1] + 1);
        return input[X-1];
    }   
}