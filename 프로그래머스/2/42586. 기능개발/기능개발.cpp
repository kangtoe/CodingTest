#include <string>
#include <vector>

using namespace std;

// 배포 가능한 가장 큰 인덱스 구하기
int check(vector<int> progresses, int start)
{
    int idx = -1;
    for( int i = start; i < progresses.size(); i++)
    {
        if(progresses[i] == -1) idx = i;
        else return idx;        
    }
    return idx;
}

vector<int> solution(vector<int> progresses, vector<int> speeds) {
    vector<int> rel;
    int frontIdx = -1;
    for(int day = 0; day < 100; day++)
    {
        for(int idx = progresses.size()-1; idx >= 0; idx--)
        {
            // progress work
            if(progresses[idx]!=-1) progresses[idx] += speeds[idx];
            
            // work done
            if(progresses[idx] >= 100)
            {
                progresses[idx] = -1;                
                int doneIdx = check(progresses, 0);
                int done = doneIdx - frontIdx; // 이번 베포에 추가로 완료된 기능 수
                
                if(done <= 0) continue;
                rel.push_back(done);
                frontIdx = doneIdx;
            }
        }
    }
    
    return rel;
}