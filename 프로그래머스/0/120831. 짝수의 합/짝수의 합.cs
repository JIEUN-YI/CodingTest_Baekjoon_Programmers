using System;

public class Solution {
    public int solution(int num) {
        int sum = 0;
        for(int i = 0; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
            else continue;
        }
        return sum;
        }
}