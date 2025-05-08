using System;
using System.Linq;
public class Solution {
    public int solution(string my_string) {
                       string[] newStr = my_string.Split(" ").ToArray();

            int result = int.Parse(newStr[0]);

            for(int i = 1; i < newStr.Length; i += 2)
            {
                int num = int.Parse(newStr[i + 1]);
                if (newStr[i] == "+")
                {
                    result += num;
                }
                else
                {
                    result -= num;
                }
            }

            return result;
    }
}