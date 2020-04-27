class Solution {
    public int solution(int N) {
        string binary = Convert.ToString(N, 2);
        var indexes = new List<int>();
        for (int i = 0; i < binary.Length; i++)
        {
            if (binary[i] == '1')
            {
                indexes.Add(i);
                
            }
            
        }
        if(indexes.Count <= 2)
        {
            return 0;
        }
        int biggest = 0;
        for (int i = 1; i < indexes.Count; i++)
        {
                biggest = Math.Max(biggest, indexes[i] - indexes[i - 1]);
        }
        if(biggest == 0)
        {
            return biggest;
        }
        return biggest - 1;
        // write your code in C# 6.0 with .NET 4.5 (Mono)
    }
}