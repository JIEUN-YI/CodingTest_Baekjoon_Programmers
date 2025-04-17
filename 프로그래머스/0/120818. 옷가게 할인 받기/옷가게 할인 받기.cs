using System;

public class Solution {
    public int solution(int n) {
        int result = 0;

        if (n >= 500000)
        {
            result = (int)Math.Floor(n * 0.8);// Math.Floor() 버림 함수
        }
        else if (n >= 300000)
        {
            result = (int)Math.Floor(n * 0.9);
        }
        else if (n >= 100000)
        {
            result = (int)Math.Floor(n * 0.95);
        }
        else result = n;
        return result;
    }
}