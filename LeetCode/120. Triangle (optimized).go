// 120. Triangle (optimized)
// https://leetcode.com/problems/triangle/
// by Equim on 17-12-24

func minimumTotal(triangle [][]int) int {
	l := len(triangle)
	if l == 1 {
		return triangle[0][0]
	}

	dp := make([]int, l)
	for i := range dp {
		dp[i] = triangle[l-1][i]
	}

	for i := l - 2; i >= 0; i-- {
		for j := 0; j <= i; j++ {
			dp[j] = triangle[i][j] + min(dp[j], dp[j+1])
		}
	}

	return dp[0]
}

func min(a, b int) int {
	if a < b {
		return a
	}

	return b
}
