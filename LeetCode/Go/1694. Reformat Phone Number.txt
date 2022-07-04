package main
///Runtime: 0 ms, faster than 100.00% of Go online submissions for Reformat Phone Number.
/// Memory Usage: 2.3 MB, less than 26.67% of Go online submissions for Reformat Phone Number.
import (
	"fmt"
	"strings"
)

func main() {
	var v = reformatNumber("123 4-5678")
	fmt.Println(v)
}
func reformatNumber(number string) string {
	var str = strings.ReplaceAll(number, "-", "")
	str = strings.ReplaceAll(str, " ", "")
	var length = len(str)
	var result = ""
	var position = 0
	if length > 4 {
		for i := 0; true; i++ {
			result = result + str[position:position+3]
			position = position + 3
			result = result + "-"
			length = length - 3
			if length <= 4 {
				break
			}

		}
	}

	if length == 4 {
		result = result + str[position:position+2]
		result = result + "-"
		position = position + 2

		result = result + str[position:position+2]
		return result

	} else {
		result = result + str[position:position+length]
		return result
	}
}
