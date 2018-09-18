package main

import "fmt"

func main() {
	var point, max int

	for i := 0; i < 5; i++ {
		fmt.Scanf("%d", &point)
		if point < 40 {
			point = 40
		}
		max += point
	}

	fmt.Println(max / 5)
}
