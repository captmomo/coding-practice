using System;
// you can also use other imports, for example:
using System.Collections.Generic;
using System.Linq;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int[] H) {
        Stack<int> blocks = new Stack<int>();
        
        //need to stack blocks up to required height.
        //e.g. 1,2,3,4,5,6,7
        //every meter add 1 block
        //e.g. 2,2,3,3,4,4,5
        //add 1 for 0,1. add 1 more 2,3, add 1 more 4,4,5
        int used = 0;
        for(int i = 0; i < H.Length; i++)
        {
            if(blocks.Count == 0)
            {
                //start a new stack
                blocks.Push(H[i]);
                used += 1;
            }
            else if(H[i] == blocks.Peek())
            {
                //reuse the current stack;
                continue;
            }
            else if(H[i] > H[i-1])
            {
                //add one block
                blocks.Push(H[i]);
                used += 1;
            }
            else if(H[i] < H[i-1])
            {
                while(blocks.Any())
                {
                    if(H[i] < blocks.Peek())
                    {
                        blocks.Pop();
                    }
                    else if(H[i] == blocks.Peek())
                    {
                        break;
                    }
                    else
                    {
                        blocks.Push(H[i]);
                        used += 1;
                        break;
                    }
                    if(blocks.Count == 0)
                    {
                        blocks.Push(H[i]);
                        used += 1;
                        break;
                    }
                }
            }
        }
        return used;

        // write your code in C# 6.0 with .NET 4.5 (Mono)
    }
}