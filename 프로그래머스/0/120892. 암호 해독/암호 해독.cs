using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string cipher, int code) {
                  List<char> Findcode = new List<char>(); // 코드를 찾을 리스트 선언
 for(int i = 0; i < cipher.Length; i++)
 {
     if((i+1) % code == 0)
     {
         Findcode.Add(cipher[i]); // 올바른 코드를 리스트에 추가
     }
 }
 string answer = new string(Findcode.ToArray());
 Console.WriteLine(answer);
 return answer;
    }
}