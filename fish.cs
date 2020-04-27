using System;
using System.Linq;
// you can also use other imports, for example:
using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A, int[] B) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        if(B.Distinct().Count() == 1)
        {
            return A.Length;
        }
        Stack<int> upStream = new Stack<int>();

        int total = A.Length;
        for(int i = 0; i < A.Length; i++)
        {
            if(B[i] ==1) //because P < Q and B[P] = 1 so stack stores old fish
            {
                upStream.Push(A[i]);
            }
            if(B[i] == 0)
            {
                while(upStream.Any())
                {

                    if(upStream.Peek() < A[i])
                    {
                        upStream.Pop();
                        total -= 1;
                    }
                    else
                    {
                        total -= 1 ;
                        break;
                    }
                }
            }
        }
        return total;
    }
}