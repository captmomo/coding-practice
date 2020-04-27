using System;
using System.Collections.Generic;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(string S)
    {
        if (string.IsNullOrWhiteSpace(S))
        {
            return 1;
        }
        Stack<char> chars = new Stack<char>();
        List<char> charList = new List<char>() { '(', '{', '[' };
        foreach (char c in S)
        {

            if (charList.Contains(c))
            {
                chars.Push(c);

            }
            else
            {
                if (chars.Count == 0)
                {
                    return 0;
                }
                if (c == ')')
                {

                    if (chars.Peek() == '(')
                    {
                        chars.Pop();
                    }
                    else
                    {
                        return 0;
                    }
                }
                if (c == '}')
                {

                    if (chars.Peek() == '{')
                    {
                        chars.Pop();
                    }
                    else
                    {
                        return 0;
                    }
                }
                if (c == ']')
                {

                    if (chars.Peek() == '[')
                    {
                        chars.Pop();
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
        if(chars.Count == 0)
        {
            return 1;
        }
        return 0;
        // write your code in C# 6.0 with .NET 4.5 (Mono)
    }
}