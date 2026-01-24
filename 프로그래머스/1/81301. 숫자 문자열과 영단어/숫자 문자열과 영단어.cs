using System;

public class Solution {
    public int solution(string s) {
                    string[] changes = new string[]
            {
                "zero", "one", "two", "three", "four",
                "five", "six", "seven", "eight", "nine"
            };
            for(int index = 0; index < changes.Length; index++)
            {
                if (s.Contains(changes[index]))
                {
                    s = s.Replace(changes[index], index.ToString());
                }
            }
            return int.Parse(s);
    }
}