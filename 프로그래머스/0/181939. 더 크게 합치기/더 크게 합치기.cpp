#include <string>
#include <vector>

using namespace std;

int solution(int a, int b) {
    int answer = 0;
    string result1;
    string result2;

    result1 = to_string(a) + to_string(b);
    result2 = to_string(b) + to_string(a);

    int answer1 = stoi(result1);
    int answer2 = stoi(result2);

    answer = max(answer1, answer2);

    return answer;
}