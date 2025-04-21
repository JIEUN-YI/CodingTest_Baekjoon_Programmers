using System;
using System.Collections.Generic;

public class Solution {
    public string solution(int age) {
                                Stack<int> stack = new Stack<int>();
            while (age > 0)
            {
                int num = age % 10;
                stack.Push(num);
                age /= 10;
            }
            char[] arr = new char[stack.Count];
            for(int i = 0; i < arr.Length; i++)
            {
                int answer = stack.Pop() + 97;
                arr[i] = (char)answer;
            }
            string ageStr = new string(arr);
            return ageStr;
    }
}