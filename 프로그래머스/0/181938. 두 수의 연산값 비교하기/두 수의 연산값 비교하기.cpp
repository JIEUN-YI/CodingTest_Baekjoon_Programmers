#include <string>
#include <vector>

using namespace std;

int solution(int a, int b) {
    int answer = 0;
    string a_s = to_string(a);
    string b_s = to_string(b);

    string sub_s;
    sub_s += a_s;
    sub_s += b_s;

    int sub = stoi(sub_s); // stoi = string to integer
    int multiple = 2 * a * b;
    answer = max(sub, multiple);

    return answer;
}
