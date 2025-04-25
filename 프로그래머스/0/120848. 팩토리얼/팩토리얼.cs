using System;

public class Solution {
    public int solution(int n) {
            int num = 1;
            for(int i = 1; i < 11; i++)
            {
                num *= i;

                if (num > n) return i - 1;
            }
            return 10;
    }
}