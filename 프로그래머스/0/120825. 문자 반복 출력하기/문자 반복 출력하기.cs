using System;

public class Solution {
    public string solution(string my_string, int n) {
            char[] charAnswer = new char[my_string.Length * n];
            char[] chars = my_string.ToCharArray();
            for(int i = 0, k = 0;i < chars.Length;i++, k+=n)
            {
                for(int j = 0;j < n; j++)
                {
                    charAnswer[k+j] = chars[i];
                }
            }
            string answer = new string(charAnswer);
            return answer;
    }
}