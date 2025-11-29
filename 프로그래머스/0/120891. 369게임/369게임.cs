using System;

public class Solution {
    public int solution(int order) {
            string input = order.ToString();
            int count = 0;
            foreach(char i in input)
            {
                if(i == '3' || i == '6' || i == '9') { count++; }
            }
            return count;
    }
}