using System;

public class Solution {
    public int[] solution(string[] strlist) {
            int[] answer = new int[strlist.Length];
            int index = 0;
            while(index < strlist.Length)
            {
                answer[index] = strlist[index].Length;
                index++;
            }

            return answer;
    }
}