using System;

public class Solution {
    public string solution(string my_string) {
                    char[] my_char = my_string.ToCharArray(); // 원래의 문자열
            char[] reverseChar = new char[my_char.Length];
            for(int i = 0, j = my_char.Length - 1; i < my_char.Length; i++, j--)
            {
                reverseChar[i] = my_char[j];
            }
            string result = new string(reverseChar);
            return result;
    }
}