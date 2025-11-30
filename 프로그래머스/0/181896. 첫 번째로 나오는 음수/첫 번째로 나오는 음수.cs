using System;

public class Solution {
    public int solution(int[] num_list) {
            int count = 0;
            int minor = 1;
            foreach (int num in num_list)
            {
                if (num < 0)
                {
                    minor = num;
                    break;
                }
            }
            if (minor == 1)
            {
                return -1;
            }
            else { return Array.IndexOf(num_list, minor); }
    }
}