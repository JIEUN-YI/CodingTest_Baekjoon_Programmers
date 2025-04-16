using System;

public class Solution {
    public int solution(int n) {
        int result;
        if( n % 7 == 0)
        {
            result = n / 7;
        }
        else
        {
            result = n / 7 + 1 ;
        }
        return result;
    }
}