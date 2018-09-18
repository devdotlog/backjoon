package main

import (
	"fmt"
)

func main() {
	var a int
	fmt.Scanf("%d", &a)

	_9498(a)
}

func _9498(input int) {
	switch {
	case input >= 60 && input <= 69:
		fmt.Println("D")
	case input >= 70 && input <= 79:
		fmt.Println("C")
	case input >= 80 && input <= 89:
		fmt.Println("B")
	case input >= 90:
		fmt.Println("A")
	default:
		fmt.Println("F")
	}
}
