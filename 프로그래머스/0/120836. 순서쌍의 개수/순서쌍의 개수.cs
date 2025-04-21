using System;

public class Solution {
    public int solution(int n) {
                    int count = 0;
            for(int i = 1; i <= n/2; i++)
            {
                if( n % i == 0)
                {
                    count++;
                }
                else continue;
            }
            count++;
            return count;
    }
}