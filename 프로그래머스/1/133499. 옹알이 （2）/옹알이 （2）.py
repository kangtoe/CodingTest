def solution(babbling):
    count = 0
    words = ["aya", "ye", "woo", "ma"]
    
    for babb in babbling:
        word = ""
        beforeWord = ""
        for c in babb:
            word += c
            if beforeWord == word:
                break
            if word in words:
                beforeWord = word
                word = ""
            if len(word) >= 4:
                break
        if word == "":
            count += 1
        
    return count