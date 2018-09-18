package main

import (
	"bufio"
	"fmt"
	"os"
	"strconv"
	"strings"
)

func main() {
	scanner := bufio.NewScanner(os.Stdin)
	w := bufio.NewWriter(os.Stdout)

	scanner.Scan()
	count, _ := strconv.Atoi(scanner.Text())

	for i := 0; i < count; i++ {
		scanner.Scan()
		inputs := strings.Split(scanner.Text(), " ")
		a, _ := strconv.Atoi(inputs[0])
		b, _ := strconv.Atoi(inputs[1])

		fmt.Fprintf(w, "%d\n", a+b)
	}

	w.Flush()
}
