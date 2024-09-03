#include <iostream>
using namespace std;
//대진 라운드인가 검사 //a b 비교 
//주의 -> abs(a - b) = 1 인가? -> 반례 a = 2, b = 3  
//추가 -> 둘 중 큰 수가 짝수인가 검사
bool IsOnRound(int a, int b)
{
    bool check1 = (a - b == 1 || a - b == -1);
    
    bool check2;
    if (a > b) check2 = (a % 2 == 0);
    else check2 = (b % 2 == 0);

    cout << a << ' ' << b << endl;
    cout << check1 << check2 << endl;
    return check1 && check2;
}      

int solution(int n, int a, int b)
{
    int answer = 1;
    while(!IsOnRound(a,b)) 
    {
        if(a%2==1) a+= 1;
        a /= 2;

        if(b%2==1) b+= 1;
        b /= 2;

        answer++;        
    }             
    return answer;
}