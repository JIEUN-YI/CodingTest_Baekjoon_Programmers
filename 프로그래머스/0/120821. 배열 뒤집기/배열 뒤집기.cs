using System;

public class Solution {
    public int[] solution(int[] num_list) {
 int[] answer = new int[num_list.Length];

 for(int i = num_list.Length - 1, j = 0; j < num_list.Length; i--, j++)
 {
     answer[j] = num_list[i];
 }
        return answer;
    }
}