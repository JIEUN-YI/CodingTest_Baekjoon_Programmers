#include <string>
#include <vector>

using namespace std;

string solution(string code) {
    vector<char> ret = vector<char>();

    bool mode = true; // true - 짝수만 확인 false - 홀수만 확인
    if (code[0] == '1') // 처음 시작이 모드 변경인 경우
    {
        mode = !mode;
    }
    else
    {
        ret.push_back(code[0]); 
    }
    for (int i = 1; i < code.length(); i++)
    {
        if (code[i] == '1')
        {
            mode = !mode; // 1인 경우 모두 변경
            continue;
        }
        if (mode) // true - 짝수
        {
            if (i % 2 == 0) // 짝수인 경우 저장
            {
                ret.push_back(code[i]);
                continue;
            }
            else
            {
                continue;
            }
        }
        else // false - 홀수
        {
            if (i % 2 == 0) // 짝수 패스
            {
                continue;
            }
            else
            {
                ret.push_back(code[i]);
                continue;
            }
        }
    }

    if (ret.size() <= 0)
    {
        string answer("EMPTY");
        return answer;
    }
    else
    {
        string answer(ret.begin(), ret.end());
        return answer;
    }
}