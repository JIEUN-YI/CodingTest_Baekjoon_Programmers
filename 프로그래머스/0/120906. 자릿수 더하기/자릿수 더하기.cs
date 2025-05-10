using System;

public class Solution {
    public int solution(int num) {
                    int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num = num / 10;
            }
            Console.WriteLine(sum);
            return sum;
    }
}