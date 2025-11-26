using System;

public class Solution {
    public int solution(int[] box, int n) {
                    int multiply = 1;
            foreach(int num in box)
            {
                multiply *= num / n;
            }
            return multiply;
    }
}