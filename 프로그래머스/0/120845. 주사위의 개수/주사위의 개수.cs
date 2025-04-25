using System;

public class Solution {
    public int solution(int[] box, int n) {
        int[] countAnwer = new int[3];
for(int i = 0; i < box.Length; i++)
{
    countAnwer[i] = box[i] / n; //각 변에 필요한 주사위 갯수 저장
}
int answer = 1;
for (int i = 0; i<countAnwer.Length; i++)
{
    answer *= countAnwer[i];
}
        return answer;
    }
}