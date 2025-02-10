#include <iostream>
using namespace std;

long long solution(int price, int money, int count)
{
    long long need = 0, use = 0;    
    while(use < count)
    {
        use++;
        need += use * price;
    }    
    cout << need;

    long long lack = need - money;
    if (lack < 0) return 0;
    return lack;
}