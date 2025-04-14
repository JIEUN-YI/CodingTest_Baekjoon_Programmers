using System;

public class Solution {
    public int[] solution(int[] array) {
        for(int i = 0; i<array.Length; i++)
        {
            array[i] *= 2;
        }
        return array;
    }
}