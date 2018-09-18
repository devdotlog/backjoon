package main

import (
	"fmt"
)

func main() {
	var a, b int
	fmt.Scanf("%d %d", &a, &b)

	data := make([]int, a)
	for i := 0; i < a; i++ {
		fmt.Scanf("%d", &data[i])
	}

	_19283(b, data)
}

func _19283(b int, data []int) {
	for _, value := range data {
		if b > value {
			fmt.Printf("%d ", value)
		}
	}
}
