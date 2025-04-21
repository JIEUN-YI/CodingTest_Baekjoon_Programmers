using System;

public class Solution {
    public int[] solution(int[] array, int num1, int num2) {
        int[] result = new int[num2 - num1 + 1];
        for (int i = 0, j = num1 ; j <= num2 ; i++, j++)
        {
            result[i] = array[j];
        }
        return result;
    }
}