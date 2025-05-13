using System;

public class Solution {
    public int solution(int n) {
                    for(int i = 1; i < n; i++)
            {
                if (n == i * i)
                {
                    return 1;
                }
                else
                    continue;
            }
            return 2;
    }
}