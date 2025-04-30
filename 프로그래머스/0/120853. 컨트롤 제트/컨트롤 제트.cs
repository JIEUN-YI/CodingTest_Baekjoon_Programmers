using System;
using System.Linq;
public class Solution {
    public int solution(string s) {
                    string[] spells = s.Split(' ').ToArray();
            int sum = 0;
            for(int i = 0; i < spells.Length; i++)
            {
                if(spells[i] == "Z")
                {
                    int.TryParse(spells[i-1], out int num);
                    sum -= num;
                }
                else
                {
                    int.TryParse(spells[i], out int num);
                    sum += num;
                }
            }
            return sum;
    }
}