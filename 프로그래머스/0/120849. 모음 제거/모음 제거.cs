using System;
using System.Text.RegularExpressions;
public class Solution {
    public string solution(string my_string) {
                    string answer;
            answer = Regex.Replace(my_string, "A", "");
            answer = Regex.Replace(answer, "a", "");
            answer = Regex.Replace(answer, "E", "");
            answer = Regex.Replace(answer, "e", "");
            answer = Regex.Replace(answer, "I", "");
            answer = Regex.Replace(answer, "i", "");
            answer = Regex.Replace(answer, "O", "");
            answer = Regex.Replace(answer, "o", "");
            answer = Regex.Replace(answer, "U", "");
            answer = Regex.Replace(answer, "u", "");
            return answer;
    }
}