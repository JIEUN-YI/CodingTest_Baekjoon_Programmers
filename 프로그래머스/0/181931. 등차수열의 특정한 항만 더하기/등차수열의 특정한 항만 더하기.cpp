#include <string>
#include <vector>

using namespace std;

int solution(int a, int d, vector<bool> included) {
    int answer = 0;

    for (int i = 0; i < included.size(); i++) // vector의 값에 따라
    {
        bool now = included[i];

        if (now) // 참이면
        {
            answer += a + d * i; // 합을 더하기

            continue;
        }
        else
        {
            continue;
        }
    }

    return answer;
}