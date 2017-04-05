// 13. Roman to Integer
// https://leetcode.com/problems/roman-to-integer
// by Equim on 17-04-06

func romanToInt(s string) int {
    romans := map[string]int{"I": 1, "V": 5, "X": 10, "L": 50, "C": 100, "D": 500, "M": 1000}

    ret, prev := 0, 1000
    for i := 0; i < len(s); i++ {
        digit := romans[string(s[i])]

        switch digit / prev {
        case 5:
            ret += 3 * prev
        case 10:
            ret += 8 * prev
        default:
            ret += digit
        }

        prev = digit
    }

    return ret
}