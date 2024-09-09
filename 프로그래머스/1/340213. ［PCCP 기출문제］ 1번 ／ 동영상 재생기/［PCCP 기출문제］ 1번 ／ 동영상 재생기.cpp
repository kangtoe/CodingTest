#include <string>
#include <vector>
#include <iostream>

using namespace std;

int sToT(string time)
{
    string m = time.substr(0, 2);
    string s = time.substr(3, 2);
     
    return stoi(m) * 60 + stoi(s);
}

string tToS(int time)
{
    int m = time / 60;
    int s = time % 60;
    
    string sm = m < 10 ? "0" + to_string(m) : to_string(m);
    string ss = s < 10 ? "0" + to_string(s) : to_string(s);
    return sm + ":" + ss;
}

string solution(string video_len, string pos, string op_start, string op_end, vector<string> commands) {
    string answer = "";
    
    int i_video_len = sToT(video_len);
    int i_pos = sToT(pos);
    int i_op_start = sToT(op_start);
    int i_op_end = sToT(op_end);
    
    for(int i = 0; i < commands.size(); i++)
    {
        // 최소최대 제한, 오프닝 스킵 체크
        if (i_pos < 0) i_pos = 0;
        if (i_video_len < i_pos) i_pos = i_video_len; 
        if (i_op_start <= i_pos && i_pos <= i_op_end) i_pos = i_op_end;
                  
        if (commands[i] == "prev") i_pos -= 10;
        if (commands[i] == "next") i_pos += 10;                     
    }
    
    // 최소최대 제한, 오프닝 스킵 체크
    if (i_pos < 0) i_pos = 0;
    if (i_video_len < i_pos) i_pos = i_video_len; 
    if (i_op_start <= i_pos && i_pos <= i_op_end) i_pos = i_op_end; 
    
    return tToS(i_pos);
}