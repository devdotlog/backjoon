package main

import (
	"fmt"
)

func main() {
	var a string
	fmt.Scanf("%s", &a)

	_11721(a)
}

func _11721(input string) {
	for i := 1; i <= len(input); i++ {
		fmt.Print(string(input[i-1]))
		if i%10 == 0 {
			fmt.Println()
		}
	}
}
