using System;

public class Solution {
    public int solution(int[] array) {
        Array.Sort(array);
        int result = array[array.Length / 2];
        return result;
    }
}