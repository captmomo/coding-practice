using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        int finalDist = A.Length + 1;
        Dictionary<int, bool> jumpDict = getJumps(finalDist);
        bool value;
        if (jumpDict.TryGetValue(finalDist, out value))
        {
            Console.WriteLine("yolo");
            return 1;
        }

        if (!A.Any(x => x == 1))
        {
            return -1;
        }
        //first jump = -1 to A[first]
        int dist = 0;
        int count = 0;
        int[] leaves = new int[A.Length + 1];
        int[] firstJump = new int[A.Length + 1];
        firstJump[A.Length] = 0;
        leaves[A.Length] = 1;
        for (int i = 0; i < A.Length; i++)
        {
            leaves[i] = A[i];
            dist = i + 1;
            if (jumpDict.TryGetValue(dist, out value))
            {
                firstJump[i] = 1;
                
            }
            
        }
        int endPoint = 0;
        for (int i = 0; i < A.Length + 1; i++)
        {
            if (leaves[i] == 1 && firstJump[i] > 0)
            {
                foreach (int num in jumpDict.Select(x => x.Key).ToArray())
                {
                    endPoint = i + num;
                    if (endPoint <= i)
                    {
                        continue;
                    }
                    if (i + num >= finalDist)
                    {
                        break;
                    }
                    //if it's a new reachable point; increase;
                    if(firstJump[endPoint] == 0)
                    {
                        firstJump[endPoint] = firstJump[i] + 1;
                        continue;
                    }
                    if (firstJump[endPoint] > firstJump[i] + 1 && firstJump[endPoint] > 1 )
                    {
                        firstJump[endPoint] = firstJump[i] + 1;
                    }

                }
            }
            else
            {
                continue;
            }
        }
        if(firstJump[A.Length] == 0)
        {
            return -1;
        }
        return firstJump[A.Length];
        // write your code in C# 6.0 with .NET 4.5 (Mono)
    }
    private static Dictionary<int, bool> getJumps(int Max)
    {
        Dictionary<int, bool> result = new Dictionary<int, bool>();
        int fib = 0;
        bool value;
        for (int i = 0; i < 27; i++)
        {
            fib = fibDynamic(i);
            if (fib > Max)
            {
                return result;
            }
            if (!result.TryGetValue(fib, out value))
            {
                result.Add(fib, true);

            }
        }
        return result;
    }
    private static int fibDynamic(int n)
    {
        int[] fib = new int[n + 2];
        fib[1] = 1;
        for (int i = 2; i < n + 1; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        return fib[n];
    }
}