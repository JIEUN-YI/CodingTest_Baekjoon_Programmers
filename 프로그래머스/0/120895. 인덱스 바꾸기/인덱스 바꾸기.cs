using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
            string answer;
            char temp;
            char[] example = my_string.ToCharArray();
            temp = example[num1];
            example[num1] = example[num2];
            example[num2] = temp;

            answer = string.Concat(example); // 문자를 연결하여 저장
            return answer;
    }
}