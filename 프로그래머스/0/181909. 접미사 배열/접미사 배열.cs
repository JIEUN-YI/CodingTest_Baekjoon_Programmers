using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
            // 접미사를 저장할 배열
            string[] suffixs = new string[my_string.Length];
            // 접미사를 저장할 배열의 인덱스
            int index = 0;
            // 총 my_string의 길이만큼 반복
            while (index < my_string.Length)
            {
                // 현재 접미사를 만들 리스트
                List<char> suffix = new List<char>(my_string.Length);
                // 시작지점 : index 값 = 처음에는 0번 위치부터 my_string.Length-1 인덱스까지 출발 지점
                for (int i = index; i < my_string.Length; i++)
                {
                    suffix.Add(my_string[i]);
                }
                // 리스트에 완성된 접미사를 배열에 저장
                suffixs[index] = new string(suffix.ToArray());
                // 인덱스 증가
                index++;
            }
            Array.Sort(suffixs);

            return suffixs;
    }
}