func tribonacci(n int) int {
    
        if n == 0 {
		return 0
	}     else if n == 1 {
		return 1
	}    else if n == 2 {
		return 1
	}
	//var result = [10]int{}
	var result = make([]int, n+1)
	result[0] = 0
	result[1] = 1
    	result[2] = 1
	for i := 3; i <= n; i++ {
		result[i] = result[i-3] +result[i-2] + result[i-1]
	}
	return result[n]
}

//Runtime: 0 ms, faster than 100.00% of Go online submissions for N-th Tribonacci Number.
//Memory Usage: 2 MB, less than 30.36% of Go online submissions for N-th Tribonacci Number.