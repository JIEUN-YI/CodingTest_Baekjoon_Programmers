#include <iostream>
#include <string>

using namespace std;

string solution(string str1, string str2);

int main()
{
    string str1;
    string str2;
    cin >> str1 >> str2;

    string answer = solution(str1, str2);
    
    return 0;
}
string solution(string str1, string str2)
{
    string answer = "";
    int count = str1.length();
    int index = 0;

    while (count > 0)
    {
        answer += str1[index];
        answer += str2[index];
        index++;
        count--;
    }

    for (char a : answer) {
        cout << a;
    }
    return answer;
}
