using System;

public class Solution {
    public int[] solution(int[] num_list) {
                    int even = 0; // 짝수
            int odd = 0; // 홀수
            foreach(int n in num_list)
            {
                if (n % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            int[] result = new int[2];
            result[0] = even;
            result[1] = odd;

            return result;
    }
}