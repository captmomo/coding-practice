using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int eastCars = 0;
        int counter = 0;
        for(int i = 0; i < A.Length; i++)
        {
            if(A[i] == 0)
            {
                eastCars += 1;
                continue;
            }
            //every time a car goes west
            //the number of pairs increase by number of cars going east
            counter += eastCars;
            if(counter > 1000000000)
            {
                return -1;
            }
        }
        return counter;
    }
}