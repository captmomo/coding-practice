using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;
// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int K, int M, int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int beg = A.Max();
        int end = A.Sum();
        int mid = 0;
        int result = 0;
        int blocks = 0;
        while(beg <= end)
        {
            mid = (beg + end)/2;
            blocks = check(A, mid);
            if(blocks <= K)
            {
                result = mid;
                end = mid - 1;
            }
            else
            {
                beg = mid + 1;
            }
        }

        return result;
    }
    private int check(int[] input, int mid)
    {
        int len = input.Length;
        int count = 1;
        int sum = 0;
        for(int i = 0; i < len; i++)
        {
            if(sum + input[i] > mid)
            {
                sum = input[i];
                count += 1;
            }
            else
            {
                sum += input[i];
            }
            //tying ropes
        }
        return count;
    }
}