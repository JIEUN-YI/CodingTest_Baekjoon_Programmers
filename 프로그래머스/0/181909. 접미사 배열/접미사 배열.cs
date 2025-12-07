using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
            string[] suffixs = new string[my_string.Length];
            int count = 0;
            while (count < my_string.Length)
            {
                List<char> suffix = new List<char>(my_string.Length - count);
                for(int index = count; index < suffixs.Length; index++)
                {
                    suffix.Add(my_string[index]);
                }
                suffixs[count] = new string(suffix.ToArray());
                count++;
            }
            Array.Sort(suffixs);

            return suffixs;
    }
}