using System;

public class Solution {
    public int solution(int[] numbers) {
                    Array.Sort(numbers); // 배열을 재정렬
            int frontNum = numbers[0] * numbers[1];
            int backNum = numbers[numbers.Length - 1] * numbers[numbers.Length - 2];

            return Math.Max(frontNum, backNum);
    }
}