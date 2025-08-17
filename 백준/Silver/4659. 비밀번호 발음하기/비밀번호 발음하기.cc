/******************************************************************************

                              Online C++ Compiler.
               Code, Compile, Run and Debug C++ program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <iostream>
#include <string>
using namespace std;

char mothers[] =  {'a','e','u','i','o'};

void printStr(bool b, string str)
{
    string n = b ? "" : "not ";
    cout << '<' << str << '>' << " is " << n << "acceptable." << endl;
}

int main()
{
    string str;
    while(true)
    {
        cin >> str;
        if(str == "end") break;
    
        bool acc = true;
        bool motherCheck = false;
        int motherContinue = 0;
        int sonContinue = 0;
        for(int i = 0; i < str.size(); i++)
        {
            char c = str[i];
            bool nowMother = false;
            for(char m : mothers)
            {
               if(c == m)
               {
                   nowMother = true;
                   motherCheck = true;
                   break;
               }
            }
            
            if(i>0&&c!='e'&&c!='o')
            {
                if(str[i-1] == c)
                {
                    acc = false;
                    break;
                }
            }
                        
            if(nowMother)
            {
                motherContinue++;   
                sonContinue = 0;
            }
            else
            {
                motherContinue=0;   
                sonContinue++;
            }
            if(motherContinue==3||sonContinue==3)
            {
                acc = false;
                break;
            }
            
        }
        acc = acc && motherCheck;
        printStr(acc, str);
    }
}
