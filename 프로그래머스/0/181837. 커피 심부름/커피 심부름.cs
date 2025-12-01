using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[] order) {
                        Dictionary<string, int> menus = new Dictionary<string, int>();
            menus.Add("iceamericano", 4500);
            menus.Add("americanoice", 4500);
            menus.Add("hotamericano", 4500);
            menus.Add("americanohot", 4500);
            menus.Add("icecafelatte", 5000);
            menus.Add("cafelatteice", 5000);
            menus.Add("hotcafelatte", 5000);
            menus.Add("cafelattehot", 5000);
            menus.Add("americano", 4500);
            menus.Add("cafelatte", 5000);
            menus.Add("anything", 4500);

            int sum = 0;
            foreach(string item in order)
            {
                if (menus.ContainsKey(item))
                {
                    sum+= menus[item];
                }
            }
            return sum;
    }
}