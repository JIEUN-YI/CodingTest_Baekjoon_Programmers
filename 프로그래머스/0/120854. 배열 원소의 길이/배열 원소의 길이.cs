using System;

public class Solution {
    public int[] solution(string[] strlist) {
        int[] answer = new int[strlist.Length];
        for(int i = 0;i < strlist.Length;i++)
        {
            char[] ex = strlist[i].ToCharArray();
            answer[i] = ex.Length;
        }
        return answer;
        }
}