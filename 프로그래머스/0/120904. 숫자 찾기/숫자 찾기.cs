using System;

public class Solution {
    public int solution(int num, int k) {
            int digit = 0;
            int count = 0;
            int i = 0;
            int hint = num;
            // 자리 수 구하기
            while (hint > 0)
            {
                hint /= 10;
                digit++;
            }
            // 자리수만큼 배열 생성
            int[] arr = new int[digit]; 
            // 배열 채우기
            while (num > 0)
            {
                int rest = num % 10;
                arr[i] = rest;
                i++;
                num /= 10;
            }

            for(int j = arr.Length-1; j >= 0 ; j--)
            {
                count++;
                if(arr[j] == k)
                {
                    return count;
                }
            }
            return -1;
    }
}