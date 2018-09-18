package main

import "fmt"

func main() {
	var count int
	fmt.Scanf("%d", &count)

	for i := 1; i <= 9; i++ {
		fmt.Printf("%d * %d = %d\n", count, i, count*i)
	}
}
