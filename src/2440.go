package main

import "fmt"

func main() {
	var num int
	fmt.Scanf("%d", &num)

	for i := 1; i <= num; i++ {
		for j := i; j <= num; j++ {
			fmt.Print("*")
		}
		fmt.Println()
	}
}
