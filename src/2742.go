package main

import "fmt"

func main() {
	var count int
	fmt.Scanf("%d", &count)

	for i := count; i > 0; i-- {
		fmt.Printf("%d\n", i)
	}
}
