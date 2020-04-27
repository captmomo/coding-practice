using System;
using System.Linq;

class Solution
{
    public int solution(int[] A)
    {
        if(!A.Any())
        {
            return -1;
        }
        if(A.Count() == 1)
        {
            return 0;
        }
        int N = A.Length;
        int[] backUp = new int[N];
        for (int i = 0; i < N; i++)
        {
            backUp[i] = A[i];
        };
        Array.Sort(A);
        int candidate = A[N / 2];
        int count = 0;
        for (int i = 0; i < N; i++)
        {
            if (A[i] == candidate)
            {
                count += 1;
            }
        }
        if (count <= N / 2)
        {
            return -1;
        }
        return Array.IndexOf(backUp, candidate);
        // write your code in Java SE 8
    }
}