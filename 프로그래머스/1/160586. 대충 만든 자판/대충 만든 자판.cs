using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
            Dictionary<char, int> map = new Dictionary<char, int>(26);
            List<int> list = new List<int>(100);
            for (int i = 0; i < keymap.Length; i++)
            {
                int count = 1;
                foreach(char c in keymap[i])
                {
                    if (map.ContainsKey(c))
                    {
                        map[c] = Math.Min(count, map[c]);
                    }
                    else
                    {
                        map.Add(c, count);
                    }
                    count++;
                }
            }
            foreach (string str in targets)
            {
                int sum = 0;
                foreach(char c in str)
                {
                    if (map.ContainsKey(c)) { sum += map[c]; }
                    else { sum = -1; break; }
                }
                list.Add(sum);
            }
            return list.ToArray();
    }
}