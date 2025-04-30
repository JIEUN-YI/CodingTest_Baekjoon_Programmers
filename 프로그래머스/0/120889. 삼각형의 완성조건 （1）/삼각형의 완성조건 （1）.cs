using System;

public class Solution {
    public int solution(int[] sides) {
         Array.Sort(sides);
         Array.Reverse(sides);
         if (sides[0] < sides[1] + sides[2])
         {
             return 1;
         }
         else
         {
             return 2;
         }
    }
}