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
