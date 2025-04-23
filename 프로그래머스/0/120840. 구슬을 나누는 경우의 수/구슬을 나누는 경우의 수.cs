using System;

public class Solution {
    public double solution(int balls, int share) {
                    double answer = 1;
            for(int count =1; balls > share; balls--, count++)
            {
                answer *= balls;
                answer /= count;
            }
            return answer;
    }
}