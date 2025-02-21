#include <string>
#include <vector>

using namespace std;

float getLean(vector<int> dot1, vector<int> dot2)
{
    return (float)(dot2[1] - dot1[1]) / (dot2[0] - dot1[0]);
}

int solution(vector<vector<int>> dots) {
    if(getLean(dots[0],dots[1])==getLean(dots[2],dots[3])) return 1;
    if(getLean(dots[0],dots[2])==getLean(dots[1],dots[3])) return 1;        
    return 0;
}