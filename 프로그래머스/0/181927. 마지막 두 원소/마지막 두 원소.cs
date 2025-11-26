using System;

public class Solution {
    public int[] solution(int[] num_list) {
            int x = num_list[num_list.Length - 2];
            int y = num_list[num_list.Length - 1];
            int last = 0;
            if(x < y)
            {
                last = y - x;     
            }
            else
            {
                last = y * 2;
            }
            int[] answer = new int[num_list.Length + 1];
            for(int i = 0; i < answer.Length; i++)
            {
                if (i == answer.Length - 1)
                {
                    answer[i] = last;
                    break;
                }
                answer[i] = num_list[i];
            }
            return answer;
    }
}