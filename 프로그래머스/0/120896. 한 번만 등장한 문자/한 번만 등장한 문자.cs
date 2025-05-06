using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
            // 문자를 문자열 배열로 만들기
            char[] spells = s.ToCharArray();
            Array.Sort(spells); // 오름차순으로 정렬
            List<char> answer = new List<char>(spells.Length);
            for(int i = 0; i < spells.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < spells.Length; j++)
                {

                    if(spells[i] == spells[j])
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (count == 1)
                {
                    answer.Add(spells[i]);
                }
            }
            string result = new string(answer.ToArray());
            return result;
    }
}