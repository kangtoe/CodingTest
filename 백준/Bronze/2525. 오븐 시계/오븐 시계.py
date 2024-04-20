# 예시 입력 받기
current_hour, current_minute = map(int, input().split())
time = int(input())

# 현재 시간을 분 단위로 변환
allminutes  = current_hour * 60 + current_minute + time

# 시간과 분으로 분리
hour = allminutes // 60
hour %= 24 
minute = allminutes % 60

# 출력
print(hour, minute)