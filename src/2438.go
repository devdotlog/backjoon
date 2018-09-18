package main

import "fmt"

func main() {
	var count int
	fmt.Scanf("%d", &count)

	for i := 1; i <= count; i++ {
		for j := 1; j <= i; j++ {
			fmt.Print("*")
		}
		fmt.Println()
	}
}
