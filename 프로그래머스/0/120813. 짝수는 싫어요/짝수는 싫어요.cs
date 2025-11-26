using System;

public class Solution {
    public int[] solution(int n) {
    // 홀수 배열을 생성
    int[] result = new int[(n+1)/2];
        for(int i = 0; i < result.Length ; i++)
        {
            result[i]= 1 + i * 2;
        }
        return result;
    }
}