#include <string>
#include <vector>

using namespace std;

int solution(vector<int> num_list) {
    string evenSum;
    string  oddSum;
    for (int i = 0; i < num_list.size(); i++)
    {
        if (num_list[i] % 2 == 0)
        {
            evenSum += to_string(num_list[i]);
        }
        else
        {
            oddSum += to_string(num_list[i]);
        }
    }

    int evenNum = stoi(evenSum);
    int oddNum = stoi(oddSum);

    return evenNum + oddNum;
}