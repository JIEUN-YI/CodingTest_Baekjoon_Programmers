#include <iostream>
#include <string>
#include <cctype> // toupper와 tolower 함수 사용을 위한 추가

using namespace std;

int main(void) {
    string str;
    cin >> str;
    for (char& c : str) // string str안의 문자열 c 
    {
        if (isupper(c)) //대문자인 경우
        {
            c = tolower(c); // 소문자로 변환 대체
        }
        else // 소문자인 경우
        {
            c = toupper(c); // 대문자로 변환 대체
        }
    }
    cout << str;
    return 0;
}