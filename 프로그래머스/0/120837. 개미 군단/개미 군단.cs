using System;

public class Solution {
    public int solution(int n) {
            int result = 0;
        if (n >= 5)
        {
            result = n / 5;
            n = n % 5;
        }
        if (n >= 3)
        {
            result += n / 3;
            n = n % 3;
        }
        if (n >= 1)
        {
            result += n / 1;
        }

        return result;
    }
}