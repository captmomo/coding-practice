using System;
using System.Linq;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
             int currentSmallest = int.MaxValue;
            int secondSum = 0;
            int firstSum = 0;
            int currentDiff = 0;
            firstSum = 0;
            secondSum = A.Sum();
            //length - 1 
            //because when i = length - 1
            //firstSum == A.Sum();
            //secondSum == 0;
            for (int i = 0; i < A.Length - 1; i++)
            {
                firstSum += A[i];
                secondSum -= A[i];
                currentDiff = Math.Abs(firstSum - secondSum);
                currentSmallest = currentDiff > currentSmallest
                    ? currentSmallest
                    : currentDiff;
            }
            return currentSmallest;
    }
}