package main

import "fmt"

func main() {
	var num int
	fmt.Scanf("%d", &num)

	for i := 0; i < num; i++ {
		for j := num - i; j < num; j++ {
			fmt.Print(" ")
		}
		for j := i; j < num; j++ {
			fmt.Print("*")
		}
		fmt.Println()
	}
}
