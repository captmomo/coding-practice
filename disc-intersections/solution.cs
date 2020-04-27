using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        // max J + A[J]
        // min J - A[j]
        
        //pair intersect if
        // J != K
        // if J < K
        // intersect if
        // Max J > min K
        // if J > K
        // intersect if
        // Min J < Max K 
        // first will intersect with all
        // if 0 + A[0] > k - A[k]
        Tuple<int, long, long>[] tuplesArray = new Tuple<int, long, long>[A.Length];
        for (long i = 0; i < A.Length; i++)
        {
            tuplesArray[i] = new Tuple<int, long, long>(A[i], i - A[i], i + A[i]);
        }
        tuplesArray = tuplesArray.OrderBy(x => x.Item2).ToArray();
        int counter = 0;
        for(int i = 0; i < A.Length - 1; i++)
        {
            for(int j= i + 1; j < A.Length && tuplesArray[j].Item2 <= tuplesArray[i].Item3; j++)
            {
                counter += 1;
                if(counter > 10000000)
                {
                    return -1;
                }
            }
        }
        return counter;
    }
}