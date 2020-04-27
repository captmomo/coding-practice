using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        //if sum of any two elements > a single element
        //return 1
        //else return 0;
        //if any two elements after the smallest sum 
        Tuple<int, long>[] tuplesArray = new Tuple<int, long>[A.Length];
        for (int i = 0; i < A.Length; i++)
        {
            tuplesArray[i] = new Tuple<int, long>(i, A[i]);
        }
        tuplesArray = tuplesArray.OrderBy(x => x.Item2).ToArray();
        double sumA = 0;
        double sumB = 0;
        double sumC = 0;
        for(int i = 0; i < A.Length - 2; i++)
        {
            for(int j = i + 1; j < A.Length - 1 && tuplesArray[j].Item1 > tuplesArray[i].Item1; j++)
            {
                for(int k = j + 1; k < A.Length && tuplesArray[k].Item1 > tuplesArray[j].Item1; k++)
                {
                    sumA = tuplesArray[i].Item2 + tuplesArray[j].Item2;
                    sumB = tuplesArray[k].Item2 + tuplesArray[j].Item2;
                    sumC = tuplesArray[i].Item2 + tuplesArray[k].Item2;
                    if(sumA > tuplesArray[k].Item2 
                    && sumB > tuplesArray[i].Item2 
                    && sumC > tuplesArray[j].Item2)
                    {
                        return 1;
                    }
                }
            }
        }
        return 0;
    }
}