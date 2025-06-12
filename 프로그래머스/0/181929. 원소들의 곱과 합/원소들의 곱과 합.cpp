#include <string>
#include <vector>

using namespace std;

int solution(vector<int> num_list) {
    int sumSquare = 0; // 합의 제곱
    int multiply = 1; // 곱

    for (int a : num_list)
    {
        sumSquare += a;
        multiply *= a;
    }
    sumSquare *= sumSquare;
    
    if (multiply < sumSquare) {
        return 1;
    }
    else
    {
        return 0;
    }
}