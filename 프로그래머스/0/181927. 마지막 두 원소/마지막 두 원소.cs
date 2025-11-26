using System;

public class Solution {
    public int[] solution(int[] num_list) {
                       int[] answer = new int[num_list.Length + 1];
            // 배열 복사
            Array.Copy(num_list, answer, num_list.Length);

            int x = num_list[num_list.Length - 2];
            int y = num_list[num_list.Length - 1];

            answer[answer.Length - 1] = y > x ? y - x : y * 2;
          
            return answer;
    }
}