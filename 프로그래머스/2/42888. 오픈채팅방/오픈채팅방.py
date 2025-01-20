def solution(record):
    dic = {}
    arr = []
    actions = {"Enter": "님이 들어왔습니다.", "Leave": "님이 나갔습니다."}

    for r in record:
        tmp = r.split(" ")
        act, uid = tmp[0], tmp[1]
        if act in ("Enter", "Change"):
            dic[uid] = tmp[2]

    for r in record:
        tmp = r.split(" ")
        act, uid = tmp[0], tmp[1]
        if act in actions:
            arr.append(f"{dic[uid]}{actions[act]}")

    return arr
