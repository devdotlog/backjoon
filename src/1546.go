package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
	"strings"
)

func main() {
	var num int

	fmt.Scanf("%d", &num)

	list := make([]float32, num, num)

	input := bufio.NewScanner(os.Stdin)
	input.Scan()
	inputs := strings.Split(input.Text(), " ")

	for i := 0; i < num; i++ {
		temp, _ := strconv.Atoi(inputs[i])
		list[i] = float32(temp)
	}

	var max float32

	for _, point := range list {
		max += point
	}

	for index, point := range list {
		list[index] = point / max * 100
	}

	fmt.Println(list)

	max = 0.0

	for _, point := range list {
		max += point
	}

	fmt.Print(max / float32(num))
}
