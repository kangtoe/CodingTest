# 예시 입력 받기
current_hour, current_minute = map(int, input().split())

# 현재 시간을 분 단위로 변환
current_time_in_minutes = current_hour * 60 + current_minute

# 45분 전의 시간 계산
previous_time_in_minutes = current_time_in_minutes - 45

if previous_time_in_minutes < 0:
  previous_time_in_minutes = 24 * 60 + previous_time_in_minutes

# 시간과 분으로 분리
previous_hour = previous_time_in_minutes // 60
previous_minute = previous_time_in_minutes % 60

# 출력
print(previous_hour, previous_minute)