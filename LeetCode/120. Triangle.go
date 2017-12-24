// 120. Triangle
// https://leetcode.com/problems/triangle/
// by Equim on 17-12-24

func minimumTotal(triangle [][]int) int {
	l := len(triangle)
	if l == 1 {
		return triangle[0][0]
	}

	dp := make([][]int, l)
	for i := range dp {
		dp[i] = make([]int, len(triangle[i]))
		for j := range dp[i] {
			dp[i][j] = triangle[i][j]
		}
	}

	for i := l - 2; i >= 0; i-- {
		for j := 0; j < len(triangle[i]); j++ {
			dp[i][j] += min(dp[i+1][j], dp[i+1][j+1])
		}
	}

	return dp[0][0]
}

func min(a, b int) int {
	if a < b {
		return a
	}

	return b
}
