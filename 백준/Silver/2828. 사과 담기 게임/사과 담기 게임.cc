#include <iostream>
using namespace std;

int arr[21] = {}; 
int main()
{
    int n,m;
    cin >> n >> m;
    
    int j;
    cin >> j;
    for(int i =0;i<j;i++)
    {
        cin >> arr[i];
    }
    
    int pos = 1;
    int move = 0;
    for(int i =0;i<j;i++)
    {
        if(arr[i] < pos)
        {
            move += pos - arr[i];
            pos = arr[i];
            
        }
        else if(arr[i] > pos + m - 1)
        {
            move += arr[i] - (pos + m - 1);
            pos = arr[i] - (m - 1);
        }
    }
    
    cout << move;

    return 0;
}