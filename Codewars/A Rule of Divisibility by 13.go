// A Rule of Divisibility by 13
// https://www.codewars.com/kata/a-rule-of-divisibility-by-13
// by Equim on 17-04-06

package kata

var div = [...]int{1, 10, 9, 12, 3, 4}

func Thirt(n int) int {
	current, i, sum := n, 0, 0

	for current > 0 {
		sum += current % 10 * div[i%6]
		current /= 10
		i++
	}

	if sum == n {
		return sum
	} else {
		return Thirt(sum)
	}
}
