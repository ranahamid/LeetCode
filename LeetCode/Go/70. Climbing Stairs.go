func climbStairs(n int) int {
       if n == 1 {
		return 1
	} else if n == 2 {
		return 2
	}
	//var result = [10]int{}
	var result = make([]int, n+1)
	result[1] = 1
	result[2] = 2
	for i := 3; i <= n; i++ {
		result[i] = result[i-2] + result[i-1]
	}
	return result[n]
}

//Runtime: 0 ms, faster than 100.00% of Go online submissions for Climbing Stairs.
//Memory Usage: 1.9 MB, less than 41.30% of Go online submissions for Climbing Stairs.