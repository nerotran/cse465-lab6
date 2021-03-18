
check: check-Madlib1 check-Madlib2

Madlib.exe: Madlib.cs
	csc Madlib.cs

%.output: Madlib.exe
	mono Madlib.exe < $*.input > $*.output

check-%: %.output
	cmp $*.output $*.expected
