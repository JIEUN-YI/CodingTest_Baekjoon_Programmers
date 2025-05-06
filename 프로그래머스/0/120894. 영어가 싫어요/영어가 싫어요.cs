using System;
using System.Collections.Generic;
public class Solution {
    public long solution(string numbers) {
        List<char> answerList = new List<char>();
Dictionary<string, char> dic = new Dictionary<string, char>(); // dictionary 저장
dic.Add("zero", '0');
dic.Add("one", '1');
dic.Add("two", '2');
dic.Add("three", '3');
dic.Add("four", '4');
dic.Add("five", '5');
dic.Add("six", '6');
dic.Add("seven", '7');
dic.Add("eight", '8');
dic.Add("nine", '9');

char[] chars = numbers.ToCharArray(); // string을 문자 배열로 저장하여
Queue<char> queue = new Queue<char>();
foreach(char c in chars) // 큐에 저장
{
    queue.Enqueue(c);
}

List<char> english = new List<char>();
while(queue.Count > 0) // 큐의 용량이 있는 동안
{
    english.Add(queue.Dequeue()); // 큐에서 문자를 빼오고
    string my_string = new string(english.ToArray()); // 문자열로 생성
    if (dic.ContainsKey(my_string)) // 동일한 문자열이 dictionary에 있으면
    {
        answerList.Add(dic[my_string]); // 결과 리스트에 숫자(문자)를 저장
        english.Clear(); // english 리스트 초기화
    }
    else // 동일한 문자열이 없으면
    {
        continue; // 계속
    }
}

string intAnswer = new string(answerList.ToArray()); // list 문자열로 변환
long.TryParse(intAnswer, out long value); //문자열을 숫자로 변환
return value;
    }
}