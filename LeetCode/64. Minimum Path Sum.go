// 64. Minimum Path Sum
// https://leetcode.com/problems/minimum-path-sum/
// by Equim on 17-12-24

const inf = 1<<31 - 1

func minPathSum(grid [][]int) int {
	height := len(grid)
	width := len(grid[0])

	dp := make([][]int, height)
	for i := range dp {
		row := make([]int, width)
		for j := range row {
			row[j] = inf
		}
		dp[i] = row
	}
	dp[0][0] = grid[0][0]

	for y := range grid {
		for x := range grid[y] {
			if x < width-1 {
				dp[y][x+1] = min(dp[y][x+1], dp[y][x]+grid[y][x+1])
			}
			if y < height-1 {
				dp[y+1][x] = min(dp[y+1][x], dp[y][x]+grid[y+1][x])
			}
		}
	}

	return dp[height-1][width-1]
}

func min(a, b int) int {
	if a < b {
		return a
	}

	return b
}
