// 226. Invert Binary Tree
// https://leetcode.com/problems/invert-binary-tree/
// by Equim on 17-09-07

/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func invertTree(root *TreeNode) *TreeNode {
	stack := []*TreeNode{}

	for p := root; p != nil || len(stack) > 0; p = p.Right {
		for q := p; q != nil; q = q.Left {
			q.Left, q.Right = q.Right, q.Left
			stack = append(stack, q)
		}
		p = stack[len(stack)-1]
		stack = stack[:len(stack)-1]
	}

	return root
}
