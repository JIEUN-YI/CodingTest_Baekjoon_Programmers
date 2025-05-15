using System;

public class Solution {
    public string solution(string my_string) {
                    string LowerStr = my_string.ToLower(); // 소문자로 문자열 변환 => ToUpper() : 대문자로 변환
            char[] chars = LowerStr.ToCharArray();
            Array.Sort(chars);
            string result = new string(chars);

            return result;
    }
}