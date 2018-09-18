package main

import "fmt"

func main() {
	var count int
	fmt.Scanf("%d", &count)

	for i := 1; i <= count; i++ {
		fmt.Printf("%d\n", i)
	}
}
