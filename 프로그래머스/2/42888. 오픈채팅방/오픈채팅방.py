def solution(record):
    
    dic = {}
    for r in record:
        tmp = r.split(" ")
        act, uid = tmp[0],tmp[1]
        if not act == "Leave": 
            nick = tmp[2]
            dic[uid] = nick
            
    arr = []
    for r in record:
        tmp = r.split(" ")
        act, uid = tmp[0],tmp[1]        
                
        if act == "Enter":
            s = dic[uid] + "님이 들어왔습니다."
            arr.append(s)
        if act == "Leave":
            s = dic[uid] + "님이 나갔습니다."        
            arr.append(s)
            
    return arr
