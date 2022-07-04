package main

import (
	"fmt"
)

var exists = struct{}{}

type set struct {
	m map[string]struct{}
}

func NewSet() *set {
	s := &set{}
	s.m = make(map[string]struct{})
	return s
}

func (s *set) Add(value string) {
	s.m[value] = exists
}

func (s *set) Remove(value string) {
	delete(s.m, value)
}

func (s *set) Length() int {
	return len(s.m)
}

func (s *set) Contains(value string) bool {
	_, c := s.m[value]
	return c
}

func main() {
	// s := NewSet()

	// s.Add("Peter")
	// s.Add("David")
	// s.Add("Peter")

	// fmt.Println(s.Contains("Peter"))  // True
	// fmt.Println(s.Contains("George")) // False

	// s.Remove("Peter")
	// fmt.Println(s.Contains("Peter")) // False

	fmt.Println(countVowelSubstrings("aeiouu"))
}

func countVowelSubstrings(word string) int {
	var count = 0
	var vowels = []string{"a", "e", "i", "o", "u"}
	for i := 0; i < len(word); i++ {
		set := NewSet()

		for j := 0; i+j < len(word) && stringInSliceCheck(word[i+j], vowels); j++ {
			set.Add(string(word[i+j]))
			if set.Length() == len(vowels) {
				count++
			}

		}
	}
	return count
}

func stringInSliceCheck(a byte, list []string) bool {
	for _, b := range list {
		if b == string(a) {
			return true
		}
	}
	return false
}
