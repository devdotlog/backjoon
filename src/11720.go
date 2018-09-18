package main

import (
	"fmt"
)

func main() {
	var a int
	var b string
	fmt.Scanf("%d", &a)
	fmt.Scanf("%s", &b)

	_11720(a, b)
}

func _11720(num int, input string) {
	var total int

	for i := 0; i < num; i++ {
		total += int(input[i] - 48)
	}

	fmt.Println(total)
}
