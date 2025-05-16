using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_str, int n) {
         List<string> answer = new List<string>();
 int len = 0; // for문을 돌릴 길이

 // 나머지가 있는 경우 배열이 하나 더 생김
 if (my_str.Length % n == 0)
 {
     len = my_str.Length / n;
 }
 else if (my_str.Length % n != 0)
 {
     len = my_str.Length / n + 1;
 }
 int i = 0;
 int count = 1;
 for (i = 0, count = 1; count < len; i += n, count++)
 {
     // Substring(a,b) : a부터 b만큼 자르기
     string str = my_str.Substring(i, n);
     answer.Add(str);
 }
 // 마지막 부분의 나머지 값 저장
 string newStr = my_str.Substring(i, my_str.Length-i);
 answer.Add(newStr);

 string[] result = answer.ToArray();
 return result;
    }
}