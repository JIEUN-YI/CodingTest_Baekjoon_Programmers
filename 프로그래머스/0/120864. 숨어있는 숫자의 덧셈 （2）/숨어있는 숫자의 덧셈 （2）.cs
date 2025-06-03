using System;
using System.Text.RegularExpressions;
public class Solution {
    public int solution(string my_string) {
                    string[] arr = Regex.Split(my_string, @"\D+");
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "")
                {
                    result[i] = int.Parse(arr[i]);
                }
            }
            int num = 0;
            for (int i = 0; i < result.Length; i++)
            {
                num += result[i];
            }
            return num;
    }
}