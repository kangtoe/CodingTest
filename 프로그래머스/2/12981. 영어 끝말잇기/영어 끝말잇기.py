def solution(n, words):
    said = []
    answer = []

    for idx, wd in enumerate(words):
        
        # 말한적 있는 단어?
        if wd in said:
            return [(idx % n) + 1, int(idx / n) + 1]
        
        # 이어지지 않음?
        if idx > 0 and words[idx - 1][-1] != wd[0]:
            return [(idx % n) + 1, int(idx / n) + 1]
        
        said.append(wd)
    
    return [0,0]