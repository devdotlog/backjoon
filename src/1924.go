package main

import "fmt"

func main() {
	var mon, day int
	fmt.Scanf("%d %d", &mon, &day)

	Test1924(mon, day)
}

func Test1924(mon, day int) {
	DAYS := []string{"SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"}
	MONTHS := []int{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}

	var total int
	for _, month := range MONTHS[:mon-1] {
		total += month
	}

	total += day
	result := total % len(DAYS)
	fmt.Println(DAYS[result])
}
