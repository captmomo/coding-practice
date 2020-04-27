using System;
using System.Linq;

class Solution
{
    public int solution(int[] A)
    {
        int leftLeader = 0;
        int rightLeader = 0;
        int pairs = 0;
        for (int i = 1; i < A.Length; i++)
        {
            if (i == 1)
            {
                leftLeader = A[0];
            }
            else
            {

                var leftArr = A.Take(i).ToArray();
                Array.Sort(leftArr);
                leftLeader = leftArr[leftArr.Length / 2];
                int count = 0;
                for (int j = 0; j < leftArr.Length; j++)
                {
                    if (leftArr[j] == leftLeader)
                    {
                        count += 1;
                    }
                }
                if(count <= leftArr.Length/2)
                {
                    //no leader
                    continue;
                }
            }
            if(i == A.Length - 1)
            {
                if(leftLeader != A[A.Length -1])
                {
                    continue;
                }
                else
                {
                    pairs += 1;
                    continue;
                }
            }
            var rightArr = A.Skip(i).ToArray();
            Array.Sort(rightArr);
            rightLeader = rightArr[rightArr.Length / 2];

            if(rightLeader != leftLeader)
            {
                continue;
            }
            int rightCount = 0;
            for (int j = 0; j < rightArr.Length; j++)
            {
                if (rightArr[j] == rightLeader)
                {
                    rightCount += 1;
                }
            }
            if (rightCount <= rightArr.Length / 2)
            {
                //no leader
                continue;
            }
            else
            {
                pairs += 1;
            }
        }
        return pairs;
    }
}

using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] A) {
        Dictionary<int, int> leftTrack = new Dictionary<int, int>();
        Dictionary<int, int> rightTrack= new Dictionary<int, int>();
        int pairs = 0;
        int value = 0;
        //all elements = 0 at the start;
        for(int k = 0; k < A.Length; k++)
        {
          if(rightTrack.TryGetValue(A[k], out value))
          {
              rightTrack[A[k]] = value + 1;
          }
          else
          {
              rightTrack.Add(A[k], 1);
          }
        }
        foreach(int i in A.Distinct())
        {
            leftTrack.Add(i, 0);
        }

        int leader = A[0];
        for(int i = 0; i < A.Length; i++)
        {
            //moving -->
            //deduct from right
            //add to left
            rightTrack[A[i]] -= 1;
            
            leftTrack[A[i]] += 1;
            
            int leftSize = i + 1;
            int rightSize = A.Length - (i + 1);
            if (i == 0 || leftTrack[A[i]] > leftTrack[leader])
            {
                leader = A[i];
                
            }
            if (leftTrack[leader] > (leftSize / 2) && rightTrack[leader] > (rightSize / 2))
            {
                pairs += 1;
            }
        }
        return pairs;
    }
}