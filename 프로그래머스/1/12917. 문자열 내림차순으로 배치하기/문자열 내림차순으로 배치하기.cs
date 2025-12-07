using System;

public class Solution {
    public string solution(string s) {
            char[] chars = s.ToCharArray();
            Array.Sort(chars);
            Array.Reverse(chars);
            string answer = new string(chars);
            return answer;
    }
}