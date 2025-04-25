using System;

public class Solution {
    public int solution(int[] numbers) {
            Array.Sort(numbers);
            Array.Reverse(numbers);
            return numbers[0] * numbers[1];
    }
}