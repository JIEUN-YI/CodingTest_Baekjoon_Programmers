using System;
using System.Collections.Generic;
public class Solution {
    public string solution(string letter) {
            Dictionary<string, char> morseDic = new Dictionary<string, char>(); // 모스부호 종류 저장
            morseDic.Add(".-", 'a'); morseDic.Add("-...", 'b'); morseDic.Add("-.-.", 'c'); morseDic.Add("-..", 'd'); morseDic.Add(".", 'e');
            morseDic.Add("..-.", 'f'); morseDic.Add("--.", 'g'); morseDic.Add("....", 'h'); morseDic.Add("..", 'i'); morseDic.Add(".---", 'j');
            morseDic.Add("-.-", 'k'); morseDic.Add(".-..", 'l'); morseDic.Add("--", 'm'); morseDic.Add("-.", 'n'); morseDic.Add("---", 'o');
            morseDic.Add(".--.", 'p'); morseDic.Add("--.-", 'q'); morseDic.Add(".-.", 'r');  morseDic.Add("...", 's'); morseDic.Add("-", 't');
            morseDic.Add("..-", 'u'); morseDic.Add("...-", 'v'); morseDic.Add(".--", 'w'); morseDic.Add("-..-", 'x'); morseDic.Add("-.--", 'y');
            morseDic.Add("--..", 'z');

            string[] morseSpell = letter.Split(' '); // 공백으로 문자를 나누어 스펠링 모스부호 별로 저장
            char[] spelling = new char[morseSpell.Length];
            for(int i = 0; i < morseSpell.Length; i++)
            {
                spelling[i] = morseDic[morseSpell[i]]; // morseDic에서 키에 알맞은 값을 저장
            }
            string answer = new string(spelling); // char 배열을 string으로 변환

            return answer;
    }
}