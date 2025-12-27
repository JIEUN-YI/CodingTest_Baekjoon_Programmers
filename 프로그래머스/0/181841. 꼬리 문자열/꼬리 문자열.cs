using System;
using System.Text;

public class Solution {
    public string solution(string[] str_list, string ex) {
 StringBuilder sb = new StringBuilder();
 foreach (string str in str_list)
 {
     if (str.Contains(ex))
     {
         continue;
     }
     else
     {
         sb.Append(str);
     }
 }
 return sb.ToString();
    }
}