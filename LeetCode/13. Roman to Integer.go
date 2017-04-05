// 13. Roman to Integer
// https://leetcode.com/problems/roman-to-integer
// by Equim on 17-04-06

func romanToInt(s string) int {
    romans := map[string]int{"I": 1, "V": 5, "X": 10, "L": 50, "C": 100, "D": 500, "M": 1000}

    ret, prev := 0, "M"
    for i := 0; i < len(s); i++ {
        digit := string(s[i])

        switch romans[digit] / romans[prev] {
        case 5:
            ret += 3 * romans[prev]
        case 10:
            ret += 8 * romans[prev]
        default:
            ret += romans[digit]
        }

        prev = digit
    }

    return ret
}