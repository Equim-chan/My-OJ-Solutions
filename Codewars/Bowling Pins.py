# Bowling Pins
# https://www.codewars.com/kata/bowling-pins/
# by Equim on 17-02-24

def bowlingPins(arr):
    if len(arr) == 0:
        return "I I I I\n I I I \n  I I  \n   I   "
    arr.sort()
    builder = ["", " ", "  ", "   "]
    for i in range(1, 11):
        line = 0 if i >= 7 else 1 if i >= 4 else 2 if i >= 2 else 3
        builder[line] += "  " if i in arr else "I "
    return '\n'.join([x.rstrip(' ').ljust(7) for x in builder])
