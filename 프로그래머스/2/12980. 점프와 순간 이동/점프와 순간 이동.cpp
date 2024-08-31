#include <iostream>
using namespace std;

// 도착지점에서 역으로 과정 되짚어보기
// 이동하고 2배씩 순간이동해서 이동했을 것임 -> 2로 나눈 나머지가 없는 경우 계속 순간이동 한 것
// 어떤 지점에서 2로 나눈 나머지가 있다면 한칸 점프한 것 -> 최소 사용 베터리 +1
int solution(int n)
{
    int remain = n;
    int count = 0;
    
    while(true)
    {
        if(remain == 0) return count;
        if(remain == 1) return count + 1;            
        
        if(remain % 2 == 0) remain /= 2;
        else {remain -= 1; count++;}
        
        //cout << remain << endl;
    }                
    return count;
}