// 12. Integer to Roman
// https://leetcode.com/problems/integer-to-roman
// by Equim on 17-04-06

import (
    "strings"
)

func compose(digit int, roman1, roman5, roman10 string) string {
    switch {
    case digit == 0:
        return ""
    case digit <= 3:
        return strings.Repeat(roman1, digit)
    case digit == 4:
        return roman1 + roman5
    case digit <= 8:
        return roman5 + strings.Repeat(roman1, digit-5)
    case digit == 9:
        return roman1 + roman10
    default:
        return ""
    }
}

func intToRoman(num int) string {
    ret := ""

    for i := 0; num > 0; num, i = num/10, i+1 {
        digit := num % 10
        switch i {
        case 0:
            ret = compose(digit, "I", "V", "X") + ret
        case 1:
            ret = compose(digit, "X", "L", "C") + ret
        case 2:
            ret = compose(digit, "C", "D", "M") + ret
        case 3:
            ret = strings.Repeat("M", digit) + ret
        }
    }

    return ret
}

