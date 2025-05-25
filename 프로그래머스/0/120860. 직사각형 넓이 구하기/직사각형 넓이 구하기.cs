using System;

public class Solution {
    public int solution(int[,] dots) {
                    int sizeX = 0;
            int sizeY = 0;
            for (int j = 0; j < dots.GetLength(0); j++)
            {
                if (dots[0, 0] != dots[j, 0] && dots[0, 1] != dots[j, 1])
                {
                    
                    sizeX = Math.Max(dots[0, 0], dots[j, 0]) - Math.Min(dots[0, 0], dots[j, 0]);
                    sizeY = Math.Max(dots[0, 1], dots[j, 1]) - Math.Min(dots[0, 1], dots[j, 1]);
                    break;
                }
            }
            int answer = sizeX * sizeY;
        return answer;
    }
}