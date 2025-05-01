using System;

public class Solution {
    public int solution(int order) {
                    int count = 0;
            while (order > 0)
            {
                int num = order % 10; // 나머지로 일의 자리 수 구하기
                order /= 10; // 몫을 order에 저장

                // num이 3, 6, 9인 경우 count 증가 
                if(num == 3 || num ==6 || num == 9)
                {
                    count++;
                }
            }
            return count;
    }
}