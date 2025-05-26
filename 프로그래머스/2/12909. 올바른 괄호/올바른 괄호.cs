using System;
using System.Collections.Generic;
public class Solution {
    public bool solution(string s) {
                    Stack<char> stack = new Stack<char>();
            char[] chars = s.ToCharArray(); // 받은 문자열을 문자 배열로 변환

            for(int i = 0; i < chars.Length; i++) // 배열이 전부 도는 동안
            {
                if(stack.Count == 0)
                {
                    if (chars[i] == ')') // 맨 처음이 닫힌 괄호인 경우 false
                    {
                        return false;
                    }
                    else // 맨 처음이 여는 괄호인 경우 시작
                    {
                        stack.Push(chars[i]);
                    }
                }
                else if(stack.Peek() == chars[i]) // 스택에서 나올 괄호와 배열에서 넣을 괄호가 같은 경우
                {
                    stack.Push(chars[i]); // 입력
                }    
                else if(stack.Peek() != chars[i]) // 서로 다른 괄호의 경우
                {
                    stack.Pop(); // 스택에서 제거
                }
            }

            if(stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
    }
}