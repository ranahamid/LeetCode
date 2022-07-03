package main

import "fmt"

func main() {
	var nums = []int{0, 0}
	var v = wiggleMaxLength(nums)
	fmt.Println((v))

}
/// Runtime: 0 ms, faster than 100.00% of Go online submissions for Wiggle Subsequence.
/// Memory Usage: 2.1 MB, less than 25.86% of Go online submissions for Wiggle Subsequence.
func wiggleMaxLength(nums []int) int {
	var f = 1
	var d = 1
	for i := 1; i < len(nums); i++ {
		if nums[i] > nums[i-1] {
			f = d + 1
		} else if nums[i] < nums[i-1] {
			d = f + 1
		}
	}
return int(math.Max(float64(f), float64(d)))
}
