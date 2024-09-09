def time_to_seconds(time_str):
    """mm:ss 형식을 초로 변환"""
    m, s = map(int, time_str.split(':'))
    return m * 60 + s

def seconds_to_time(seconds):
    """초를 mm:ss 형식으로 변환"""
    m = seconds // 60
    s = seconds % 60
    return f"{m:02}:{s:02}"

def adjustTime(curr, amountSec, video_len):
    """현재 시간을 amountSec 만큼 조정"""
    curr_sec = time_to_seconds(curr)
    video_sec = time_to_seconds(video_len)
    
    # 10초 전으로 갈 경우 최소 0초를 유지
    new_time = max(0, curr_sec + amountSec)
    
    # 영상 종료 시간 제한
    new_time = min(new_time, video_sec)
    
    return seconds_to_time(new_time)

def solution(video_len, pos, op_start, op_end, commands):
    for c in commands:
        # 오프닝 구간에 있으면 오프닝 끝으로 이동
        if op_start <= pos <= op_end:
            pos = op_end

        if c == 'prev':
            pos = adjustTime(pos, -10, video_len)
        if c == 'next':
            pos = adjustTime(pos, 10, video_len)

    # 마지막으로 오프닝 구간 체크
    if op_start <= pos <= op_end:
        pos = op_end

    return pos
