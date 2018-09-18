package main

import "fmt"

func main() {
	var n int
	fmt.Scanf("%d", &n)
	fmt.Printf("%d\n", countPackage(n))
	/*
		for n := 3; n <= 50; n++ {
			fmt.Printf("%d: %d\n", n, countPackage(n))
		}
	*/
}

func countPackage(n int) (pkg int) {
	for n%5 != 0 {
		if n > 5 || n == 3 {
			n -= 3
			pkg++
		} else if n < 5 {
			pkg = -1
			return
		}
	}

	pkg = n/5 + pkg
	return
}
