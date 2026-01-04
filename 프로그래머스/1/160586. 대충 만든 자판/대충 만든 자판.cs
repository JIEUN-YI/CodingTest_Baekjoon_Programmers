using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
            int[] map = new int[26];
            List<int> list = new List<int>(100);

            foreach(string key in keymap)
            {
                int count = 1;
                foreach(char c in key)
                {
                    if (map[c - 'A'] != 0)
                    {
                        map[c - 'A'] = Math.Min(count, map[c - 'A']);
                    }
                    else { map[c - 'A'] = count; }
                    count++;
                }
            }

            foreach (string str in targets)
            {
                int sum = 0;
                foreach (char c in str)
                {
                    if (map[c - 'A'] != 0) { sum += map[c - 'A']; }
                    else { sum = -1; break; }
                }
                list.Add(sum);
            }
            return list.ToArray();
    }
}