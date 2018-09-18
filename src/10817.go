package main

import (
	"fmt"
)

func main() {
	a := [3]int{}
	fmt.Scanf("%d %d %d", &a[0], &a[1], &a[2])

	_10817(a)
}

func _10817(input [3]int) {
	var loop bool
	for {
		loop = false

		if input[0] < input[1] {
			input[0], input[1] = input[1], input[0]
			loop = true
		}
		if input[1] < input[2] {
			input[1], input[2] = input[2], input[1]
			loop = true
		}

		if !loop {
			break
		}
	}

	fmt.Printf("%d\n", input[1])
}
