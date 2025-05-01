using System;

public class Solution {
    public string solution(string my_string) {
                    char[] change = my_string.ToCharArray();
            for(int i = 0 ; i < change.Length; i++)
            {
                // 대문자인 경우
                if (char.IsUpper(change[i]))
                {
                    // 소문자로 변경
                    change[i] = char.ToLower(change[i]);
                }
                // 소문자인 경우
                else if (char.IsLower(change[i]))
                {
                    // 대문자로 변경
                    change[i] = char.ToUpper(change[i]);
                }
            }
            string answer = new string(change);
        return answer;
    }
}