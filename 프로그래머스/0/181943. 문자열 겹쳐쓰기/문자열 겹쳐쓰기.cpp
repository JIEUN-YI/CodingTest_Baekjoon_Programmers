#include <iostream>
#include <string>
#include <vector>

using namespace std;

string solution(string my_string, string overwrite_string, int s) {
    my_string.replace(s, overwrite_string.length(),overwrite_string); // s번째부터 overwrite_string의 길이만큼 overwrite_string으로 대체
    return my_string;
}
int main() {
    string input;
    string overwrite;
    int s; 
    cin >> input >> overwrite >> s;
    cout << solution(input, overwrite, s) << endl;
    return 0;
}