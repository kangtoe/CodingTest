def solution(spell, dic):
    answer = 0
    spell.sort()
    
    for word in dic:
        arr = list(word)
        arr.sort()
        
        if len(spell) != len(arr):
            continue
        
        same = True
        for i in range(len(spell)):
            same = spell[i] == arr[i]
            if not same:
                break
        if same:
            return 1
    
    return 2