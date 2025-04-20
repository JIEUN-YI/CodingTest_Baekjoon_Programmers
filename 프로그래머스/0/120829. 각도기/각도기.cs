using System;

public class Solution {
    public int solution(int num) {
                    int result = 0;
            if (0 < num && num < 90)
            {
                result = 1;
            }
            else if (num == 90)
            {
                result = 2;
            }
            else if (90 < num && num < 180)
            {
                result = 3;
            }
            else if (num == 180)
            {
                result = 4;
            }
            return result;
    }
}