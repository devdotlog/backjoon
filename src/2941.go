package main

import "fmt"

func main() {
	var alpabat string

	fmt.Scanf("%s", &alpabat)

	for i := 0; i < len(alpabat); i++ {
		fmt.Println(string(alpabat[i]))
	}
}
