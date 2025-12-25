using System;
using System.Text;

public class Solution {
    public string solution(string s, string skip, int index) {
            // 알파벳 맵핑 'a' = 97 == 0번째 인덱스
            int[] mapping = new int[26];
            foreach(char c in skip)
            {
                // 제외해야하는 알파벳 표시
                if(mapping[c-'a'] == 0)
                {
                    mapping[c - 'a'] = 1;
                }
            }
            StringBuilder sb = new StringBuilder();
            // 암호문을 탐색
            foreach(char c in s)
            {
                // 기준이 되는 char 배열의 인덱스 값
                int key = c - 'a';
                // 찾을 횟수
                int count = 0; 

                while (count < index)
                {
                    // key+1이 범위를 벗어나면
                    if (key + 1 >= mapping.Length)
                    { 
                        //다시 시작
                        key = -1;
                    }
                    
                    // 통과여부확인
                    if (mapping[key + 1] == 0)
                    {
                        key++;
                        count++;
                    }
                    else { key++; continue; }
                }
                sb.Append((char)(key + 'a'));
            }
            string result = sb.ToString();
            return result;
    }
}