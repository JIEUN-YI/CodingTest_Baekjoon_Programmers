using System;

public class Solution {
    public int solution(string[] order) {
            int sum = 0;
            foreach(string item in order)
            {
                if (item.Contains("cafelatte"))
                {
                    sum += 5000;
                }
                else
                {
                    sum += 4500;
                }
            }
            return sum;
    }
}