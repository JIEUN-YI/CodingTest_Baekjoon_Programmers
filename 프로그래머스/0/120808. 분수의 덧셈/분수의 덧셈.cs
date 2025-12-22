using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int[2];
        int comdenom = denom1 * denom2; //공통의 분모
        int comnum = numer1 * denom2 + numer2 * denom1;
        //첫번째 분수의 분자 통분 + 두번째 분수의 분자 통분 = 공통의 분자

        int comdivisor = Getgcd(comnum, comdenom);
        answer[0] = comnum / comdivisor; //통분 후 약분한 분자
        answer[1] = comdenom / comdivisor;// 통분 후 약분한 분모
        
        return answer;
    }
    public static int Getgcd(int num1, int num2)//두 수의 최대공약수를 구하는 함수
{
    // 두 수의 크기를 비교
    if (num1 < num2) //num1의 수가 작은 경우 변경
    {
        int temp = num1;
        num1= num2;
        num2= temp;
    }

    if(num1 % num2 == 0)// 두 수를 나눈 나머지가 0이면
    {
        return num2; //나누는 수가 최대공약수
    }
    else
    {
        return Getgcd(num2, num1 % num2);//최대공약수가 나올때까지 재귀함수로 반복
    }
}
    
}