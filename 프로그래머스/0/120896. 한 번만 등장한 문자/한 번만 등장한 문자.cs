using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
           Dictionary<char, int> dic = new Dictionary<char, int>(s.Length);
            foreach (char c in s)
            {
                if (dic.ContainsKey(c))
                {
                    dic[c]++;
                }
                else
                {
                    dic.Add(c, 1);
                }
            }
            List<char> list = new List<char>();
            foreach (char c in dic.Keys)
            {
                if (dic[c] == 1)
                {
                    list.Add(c);
                }
            }
                    list.Sort();
            string answer = new string(list.ToArray());
            return answer;
    }
}