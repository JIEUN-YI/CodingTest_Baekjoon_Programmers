using System;

public class Solution {
    public int[] solution(int n) {
        int count = 0;
        for(int i = 1; i <= n; i++)
        {
         if (i % 2 != 0)
            {
               count++;
            }
        else continue;
        }
    int[] result = new int[count];
        for(int i = 0, j = 1 ; i < count ; j++)
        {
        if (j % 2 != 0)
         {
            result[i] = j;
            i++;
         }
        else continue;
        }
        return result;
    }
}