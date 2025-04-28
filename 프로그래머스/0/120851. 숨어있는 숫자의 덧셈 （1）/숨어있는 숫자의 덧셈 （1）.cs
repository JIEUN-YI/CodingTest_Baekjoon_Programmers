using System;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(string my_string) { 
            string arr = Regex.Replace(my_string, @"[^0-9]","");
            char[] answer = arr.ToCharArray();
            int result = 0;
            for(int i = 0; i < answer.Length; i++)
            {
                result += (int)char.GetNumericValue(answer[i]);

            }
            return result;
    }
}