using System;

public class Solution {
    public int solution(int[] sides) {
                    int minNum = Math.Max(sides[0], sides[1]) - Math.Min(sides[0], sides[1]) + 1; // 삼각형 조건의 최소값
            int maxNum = sides[0] + sides[1] - 1; // 삼각형 조건의 최대값

            int answer = maxNum - minNum + 1; // 가능한 값의 개수

            return answer;
    }
}