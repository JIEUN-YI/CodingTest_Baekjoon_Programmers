using System;

public class Solution {
    public int[] solution(int n) {
        int[] result = new int[2];
        result[0] = n / 5500;
        result[1] = n % 5500;

        return result;
    }
}