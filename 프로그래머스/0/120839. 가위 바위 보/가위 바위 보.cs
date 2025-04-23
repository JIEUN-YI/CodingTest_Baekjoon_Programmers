using System;

public class Solution {
    public string solution(string rsp) {
                    char[] answer = new char[rsp.Length];
            for (int i = 0; i < rsp.Length; i++)
            {
                switch (rsp[i])
                {
                    case '0':
                        answer[i] = '5';
                        break;
                    case '2':
                        answer[i] = '0';
                        break;
                    case '5':
                        answer[i] = '2';
                        break;
                }
            }
            string result = new string(answer);
            return result;
    }
}