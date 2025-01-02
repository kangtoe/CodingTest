# 문자 입력 최소 카운트 찾기
def getCount(s, keymap):
    
    tmpArr = []
    for key in keymap:
        idx = key.find(s)
        if not idx == -1:
            tmpArr.append(idx)
    
    #print(s, tmpArr)
    if tmpArr == []: return - 1
    return min(tmpArr) + 1

def solution(keymap, targets):
    arr = []
    for target in targets:
        wordCount = 0
        for s in target:
            count = getCount(s, keymap)
            if count == -1:
                wordCount = -1
                break
            wordCount += count
        arr.append(wordCount)
    
    return arr