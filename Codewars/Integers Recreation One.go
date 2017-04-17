// Integers: Recreation One
// https://www.codewars.com/kata/integers-recreation-one
// by Equim on 17-04-18

package kata

import (
	"math"
)

func worker(n int) int {
	sum := 0

	for i := 1; i <= int(math.Floor(math.Sqrt(float64(n)))); i++ {
		if n%i == 0 {
			diva := n / i
			divb := n / diva
			if diva != divb {
				sum += diva*diva + divb*divb
			} else {
				sum += diva * diva
			}
		}
	}

	if int(math.Pow(float64(int(math.Sqrt(float64(sum)))), float64(2))) == sum {
		return sum
	} else {
		return 0
	}
}

func ListSquared(m, n int) [][]int {
	ret := [][]int{}

	for i := m; i <= n; i++ {
		result := worker(i)
		if result > 0 {
			ret = append(ret, []int{i, result})
		}
	}

	return ret
}
