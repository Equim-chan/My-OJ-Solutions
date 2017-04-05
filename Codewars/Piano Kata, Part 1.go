package kata

func BlackOrWhiteKey(keyPressCount int) string {
	order := [...]bool{true, false, true, true, false, true, false, true, true, false, true, false}
	if order[(keyPressCount-1)%88%12] {
		return "white"
	} else {
		return "black"
	}
}
