s = input()
an = ''
cnt = 0

def endC():
    global an, cnt
    if cnt == 1 or cnt == 3:
        return -1 
    if cnt == 2:
        an += 'BB'
    elif cnt == 4:
        an += 'AAAA'
    cnt = 0

    return 0

def func():
    global an, cnt
    for c in s:
        if c == 'X':
            cnt += 1
            if cnt == 4:
                an += 'AAAA'
                cnt = 0
        elif c == '.':
            if endC() == -1: return -1
            an += '.'

    if endC() == -1: return -1
    
    return an  # 변환된 결과 반환

print(func())  