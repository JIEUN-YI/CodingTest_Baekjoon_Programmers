using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
             int sizeX = board[0] / 2; // x의 사이즈
            int sizeY = board[1] / 2; // y의 사이즈

            int x = 0; // 오른쪽 +1 / 왼쪽 -1
            int y = 0; // 위쪽 +1 / 아랫쪽 -1
            foreach (string key in keyinput)
            {
                switch (key)
                {
                    case "up":
                        y++;
                        if (y > sizeY) { y = Math.Min(y, sizeY); }
                        break;
                    case "down":
                       y--;
                        if (y < -sizeY) { y = Math.Max(y, -sizeY); }
                        break;
                    case "left":
                        x--; 
                        if (x < -sizeX) { x = Math.Max(x, -sizeX); }
                        break;
                    case "right":
                        x++;
                        if (x > sizeX) { x = Math.Min(x, sizeX); }
                        break;
                }
            }

            int[] answer = new int[2];
            answer[0] = x;
            answer[1] = y;
            return answer;
    }
}