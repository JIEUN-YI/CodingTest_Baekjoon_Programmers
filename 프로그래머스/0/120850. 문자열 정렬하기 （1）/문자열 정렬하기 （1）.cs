using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

public class Solution {
    public int[] solution(string my_string) {
                    string newString = Regex.Replace(my_string, @"\D", "");
            char[] strings = newString.ToCharArray();
            int[] answer = new int[strings.Length];

            for(int i = 0; i < strings.Length; i++)
            {
                string change = strings[i].ToString();
                answer[i] = int.Parse(change);
            }
                    Array.Sort(answer);
            return answer;
    }
}