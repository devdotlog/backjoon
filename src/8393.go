package main

import "fmt"

func main() {
	var a int
	fmt.Scanf("%d", &a)

	_8394(a)
}

func _8394(num int) {
	var total int
	for i := 1; i <= num; i++ {
		total += i
	}

	fmt.Println(total)
}
