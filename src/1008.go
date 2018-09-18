package main

import "fmt"

func main() {
	var a, b uint32
	fmt.Scanf("%d %d", &a, &b)
	fmt.Printf("%g\n", float64(a)/float64(b))
}
