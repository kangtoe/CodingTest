#include <vector>
#include <set>
using namespace std;

int solution(vector<int> nums)
{
    int nums_l = nums.size() / 2;
    
    set<int> unique_nums(nums.begin(), nums.end());
    int arr_l = unique_nums.size();
    
    return min(arr_l, nums_l);
}