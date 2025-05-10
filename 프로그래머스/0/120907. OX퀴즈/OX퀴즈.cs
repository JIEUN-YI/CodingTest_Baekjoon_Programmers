using System;

public class Solution {
    public string[] solution(string[] quiz) {
                   string[] answer = new string[quiz.Length]; // return 할 최종 배열
           for (int count = 0; count < quiz.Length; count++) // 주어진 배열을 돌면서
           {
               string[] formula = quiz[count].Split(" "); // 분할한 string[] 제작
               int.TryParse(formula[0], out int num); // 처음은 무조건 숫자로 시작

               for (int i = 2; i < formula.Length; i++) // 길이만큼 돌면서
               {
                   if (formula[i - 1].Contains("+")) // 그 다음 문자열이 + 인지
                   {
                       int.TryParse(formula[i], out int a);
                       num += a;
                   }
                   else if (formula[i - 1].Contains("-")) // 그 다음 문자열이 - 인지
                   {
                       int.TryParse(formula[i], out int a);
                       num -= a;
                   }
               }
               string find = new string(num.ToString());
               // 값과 결과가 동일한지 확인
               if (find == formula[formula.Length - 1])
               {
                   answer[count] = "O";
               }
               else
               {
                   answer[count] = "X";
               }
           }

           return answer;
    }
}