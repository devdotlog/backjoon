package main

import "fmt"

func main() {
	var alpabats string

	fmt.Scanf("%s", &alpabats)

	for i := 0; i < len(alpabats); i++ {
		fmt.Println(string(alpabats[i]))
	}
}
