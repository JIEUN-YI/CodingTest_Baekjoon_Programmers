using System;
using System.Linq;
public class Solution {
    public string solution(string polynomial) {
                    string[] numStr = polynomial.Split(" ").ToArray(); // 받은 식을 문자 배열로 생성
            int unclear = 0;
            int constant = 0;
            string answer;
            for (int i = 0; i < numStr.Length; i++)
            {
                if (numStr[i].Contains("x")) // 미지수 x를 포함하는 경우
                {
                    int.TryParse(numStr[i].Replace("x", ""), out int a); // x를 제외하고 숫자로 변환하여 저장
                    if (a == 0) // 0 인 경우 x가 1개이므로
                    {
                        unclear += 1;
                    }
                    else
                    {
                        unclear += a;
                    }
                }
                else // x가 없는 식의 경우, 상수
                {
                    int.TryParse(numStr[i], out int a); 
                    constant += a;
                }
            }

            if (unclear > 1)
            {
                if (constant == 0)
                {
                    answer = $"{unclear}x";
                }
                else
                {
                    answer = $"{unclear}x + {constant}";
                }
            }
            else if(unclear == 1)
            {
                if (constant == 0)
                {
                    answer = $"x";
                }
                else
                {
                    answer = $"x + {constant}";

                }
            }
            else
            {
                if (constant == 0)
                {
                    answer = "";
                }
                else
                {
                    answer = $"{constant}";

                }
            }
            return answer;
    }
}