using System;

public class Solution {
    public double solution(int[] array) {
        double sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        double result = sum / array.Length;
        return result;
    }
}