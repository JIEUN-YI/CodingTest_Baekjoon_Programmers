using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
 int sizeX = board[0] / 2; // x의 사이즈
 int sizeY = board[1] / 2; // y의 사이즈
 Console.WriteLine($"{sizeX} : {sizeY}");

 int x = 0; // 오른쪽 +1 / 왼쪽 -1
 int y = 0; // 위쪽 +1 / 아랫쪽 -1
 foreach (string key in keyinput)
 {
     switch (key)
     {
         case "up":
             y += 1;
             break;
         case "down":
             y -= 1;
             break;
         case "left":
             x -= 1;
             break;
         case "right":
             x += 1;
             break;
     }
     if (x < sizeX * -1)
     {
         x = Math.Max(x, sizeX * -1);
     }
     else if (x > sizeX)
     {
         x = Math.Min(x, sizeX);
     }
     if (y < sizeY * -1)
     {
         y = Math.Max(y, sizeY * -1);
     }
     else if (y > sizeY)
     {
         y = Math.Min(y, sizeY);
     }
 }

 int[] answer = new int[2];
 answer[0] = x;
 answer[1] = y;
            return answer;

    }
}