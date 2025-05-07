using System;

public class Solution {
    public int solution(string message) {
                    char[] chars = message.ToCharArray();
            int result = chars.Length * 2;

            return result;
    }
}