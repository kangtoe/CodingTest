#include <string>
#include <vector>

using namespace std;

void func(const vector<int> numbers, int target, int idx, int value, int& cnt) {
    // 기저 조건: 모든 숫자를 사용한 경우
    if (idx == numbers.size()) {
        if (value == target) {
            cnt++;
        }
        return;
    }

    // 현재 숫자를 더하거나 빼는 두 가지 경우를 탐색
    func(numbers, target, idx + 1, value + numbers[idx], cnt);
    func(numbers, target, idx + 1, value - numbers[idx], cnt);
}

int solution(vector<int> numbers, int target) {
    int cnt = 0;  // 경우의 수 초기화
    func(numbers, target, 0, 0, cnt);
    return cnt;
}
