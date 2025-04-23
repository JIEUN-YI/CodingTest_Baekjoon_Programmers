using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
                    int count = 0;
            // 열과 행의 위치와 배열의 길이를 조심할 것
            int[,] answer = new int[num_list.Length / n, n];

            for (int row = 0; row < num_list.Length / n; row++)
            {
                for (int num = 0; num < n; num++)
                {
                    answer[row, num] = num_list[count];
                    count++;
                }
            }
            return answer;
    }
}