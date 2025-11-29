using System;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(string my_string) { 
           
            int sum = 0;
            foreach(char a in my_string)
            {
                // char 가 유니코드 숫자인지 판별
                if (Char.IsNumber(a))
                {
                    // GetNumericValue : 숫자 형식의 유니코드 문자를 숫자로 변환
                    sum += (int)Char.GetNumericValue(a);
                }
            }
            return sum;
    }
}