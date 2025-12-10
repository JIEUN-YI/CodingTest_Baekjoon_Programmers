using System;
using System.Collections.Generic;

    public class Pos
    {
        public int x;
        public int y;
        public Pos(int y, int x)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(string key)
        {
            switch (key)
            {
                case "up":
                    y++;
                    break;
                case "down":
                    y--;
                    break;
                case "left":
                    x--;
                    break;
                case "right":
                    x++;
                    break;
            }
        }
        public void Clmap(int sizeX, int sizeY)
        {
            x = Math.Clamp(x, -sizeX, sizeX);
            y = Math.Clamp(y, -sizeY, sizeY);
        }
     }

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
 int sizeX = board[0] / 2; // x의 사이즈
int sizeY = board[1] / 2; // y의 사이즈

Pos nowPos = new Pos(0, 0);

foreach (string key in keyinput)
{
    // 캐릭터의 이동에 집중
    nowPos.Move(key);
    nowPos.Clmap(sizeX, sizeY);

}

return new int[] { nowPos.x, nowPos.y };
    }
}