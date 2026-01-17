using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
                    Dictionary<string, string> map = new Dictionary<string, string>(10);
            map.Add("zero", "0"); map.Add("one", "1"); map.Add("two", "2"); map.Add("three", "3");
            map.Add("four","4"); map.Add("five", "5"); map.Add("six", "6"); map.Add("seven", "7");
            map.Add("eight","8"); map.Add("nine", "9");

            foreach(string num in map.Keys)
            {
                if (s.Contains(num))
                {
                   s = s.Replace(num, map[num]);
                }
            }
            int.TryParse(s, out int result);
            Console.WriteLine(result);
            return result;
    }
}