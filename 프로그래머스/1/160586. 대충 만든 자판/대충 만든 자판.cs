using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
            int[] map = new int[28];
            List<int> list = new List<int>(100);
            for (int i = 0; i < keymap.Length; i++)
            {
                int count = 1;
                foreach (char c in keymap[i])
                {
                    if (map[c - 65] != 0)
                    {
                        map[c - 65] = Math.Min(count, map[c - 65]);
                    }
                    else { map[c - 65] = count; }
                    count++;
                }
            }
            foreach (string str in targets)
            {
                int sum = 0;
                foreach (char c in str)
                {
                    if (map[c - 65] != 0) { sum += map[c - 65]; }
                    else { sum = -1; break; }
                }
                list.Add(sum);
            }
            return list.ToArray();
    }
}