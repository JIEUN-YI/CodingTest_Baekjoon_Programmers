using System;
using System.Collections.Generic;
public class Solution {
            public void FindHanoi(int n, int start, int middle, int end, List<(int, int)> finding)
        {
            // 1개면 바로 끝으로 이동
            if (n == 1)
            {
                finding.Add((start, end));
                return;
            }
            // 하노이의 탑 핵심
            // n-1은 시작지점은 동일, end가 중간 막대가 되고, middle을 목표로 이동
            FindHanoi(n - 1, start, end, middle, finding);
            // 처음에서 끝으로 밑에 있던 항목 이동 후
            finding.Add((start, end));
            // 중간점에 있는 내용을 start를 중간 막대 삼아 end을 목표로 이동
            FindHanoi(n - 1, middle, start, end, finding);
        }
    public int[,] solution(int n) {
                    List<(int, int)> finding = new List<(int, int)>();
            FindHanoi(n, 1, 2, 3, finding);
            int[,] answer = new int[finding.Count, 2];
            for(int y  = 0; y < answer.GetLength(0); y++)
            {
                answer[y, 0] = finding[y].Item1;
                answer[y, 1] = finding[y].Item2;
            }

            return answer;
    }
}