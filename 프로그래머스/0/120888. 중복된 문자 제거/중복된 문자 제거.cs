using System;
using  System.Collections.Generic;
public class Solution {
    public string solution(string my_string) {
         List<char> words = new List<char>();
 foreach (char c in my_string)
 {
     if (words.Contains(c)) // 중복인 경우 제외
     {
         continue;
     }
     else if (!words.Contains(c)) // 중복이 아닌 경우 저장
     {
         words.Add(c);
     }
 }
 string answer = new string(words.ToArray());
 return answer;
    }
}