// 121. Best Time to Buy and Sell Stock
// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
// by Equim on 17-12-24

func maxProfit(prices []int) int {
	l := len(prices)
	if l <= 1 {
		return 0
	}
	if l == 2 {
		return max(prices[1]-prices[0], 0)
	}

	dpmin, dpmax := make([]int, l), make([]int, l)
	dpmin[0], dpmax[l-1] = prices[0], prices[l-1]

	for i := 1; i < l-1; i++ {
		dpmin[i] = min(dpmin[i-1], prices[i])
		dpmax[l-1-i] = max(dpmax[i+1], prices[l-1-i])
	}
	dpmin[l-1] = min(dpmin[l-2], prices[l-1])
	dpmax[0] = max(dpmax[1], prices[0])

	ret := 0
	for i := 0; i < l; i++ {
		if m := dpmax[i] - dpmin[i]; m > ret {
			ret = m
		}
	}

	return ret
}

func min(a, b int) int {
	if a < b {
		return a
	}

	return b
}

func max(a, b int) int {
	if a > b {
		return a
	}

	return b
}
