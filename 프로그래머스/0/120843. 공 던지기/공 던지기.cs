using System;

public class Solution {
    public int solution(int[] numbers, int k) {
                    int answer = 0;
            for (int i = 0, count = 1; count <= k; count++)
            {
                if (i >= numbers.Length)
                {
                    i -= numbers.Length;
                }

                answer = numbers[i];
                i += 2;
            }

            return answer;
    }
}