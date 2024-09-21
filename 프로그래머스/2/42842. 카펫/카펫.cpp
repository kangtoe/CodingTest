#include <string>
#include <vector>
#include <iostream>

using namespace std;

vector<int> solution(int brown, int yellow) {
    vector<int> answer = {-1, -1};
    // yellow = n * m
    // all = (n+2) * (m+2)
    // brown = all - yellow
    // ans => [n+2, m+2]
    
    for(int n = 1; n <= brown; n++)
    {
        for(int m = 1; m <= brown; m++)
        {
            if (yellow != m * n) continue;            
            if (brown != ((n+2) * (m+2) - (n * m))) continue;
                        
            int max = n < m ? m : n;
            int mim = n > m ? m : n;
            answer = {max + 2, mim + 2};
            return answer;
        }
    }
            
    return answer;
}