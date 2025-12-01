using System;

public class Solution {
    public long solution(long n) {
            string input = n.ToString();
            int[] ints = new int[input.Length];

            for(int i = 0; i < ints.Length; i++)
            {
                ints[i] = (int)input[i] - 48;
            }
            Array.Sort(ints);
            Array.Reverse(ints);

            string after = string.Join("", ints);
            long.TryParse(after, out long result);
            return result;
    }
}