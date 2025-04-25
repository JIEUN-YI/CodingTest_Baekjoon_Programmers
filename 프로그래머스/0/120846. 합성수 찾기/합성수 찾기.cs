using System;

public class Solution {
    public int solution(int num) {
                    int count = 0;
            int composit = 0;
            for(int i = 2; i <= num; i++)
            {
                for(int j = 1; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        count++;
                    }
                    continue;
                }
                if(count >= 2)
                {
                    composit++;
                }
                count = 0;
            }
            return composit;
    }
}