using System;

public class Solution {
    public int solution(int n) {
                     int piece = 0;
            for(int i = 1; ; i++)
            {
                if ((n * i) % 6 == 0)
                {
                    piece = i;
                    break;
                }
            }
            int pizza = (n * piece) / 6;

            return pizza;
    }
}