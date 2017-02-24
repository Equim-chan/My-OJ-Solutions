# Rectangle into Squares
# https://www.codewars.com/kata/rectangle-into-squares/
# by Equim on 17-02-24

def sqInRect(lng, wdth):
    if (lng == wdth):
        return None
    import math
    lng, wdth = max(lng, wdth), min(lng, wdth)
    ret = []
    while (lng % wdth != 0):
        count = math.floor(lng / wdth)
        lng, wdth = wdth, lng - wdth if count < 2 else lng % wdth
        ret.extend([lng] * count)
    ret.extend([wdth] * math.floor(lng / wdth))
    return ret
