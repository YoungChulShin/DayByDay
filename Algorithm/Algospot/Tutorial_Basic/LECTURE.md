###Name
LECTURE

###URL
[LINK](https://www.algospot.com/judge/problem/read/LECTURE)

###문제
Professor Lew teaches Algorithm course in Sonyusi University (소녀시대학교).
It is his first year as a professor, so he spends a lot of time making lecture notes.
He'll teach recursion and sorting algorithms in the next class,
and he wants to make some examples which will be included in his lecture note.

While making some examples for his lecture note, he noticed that one of his work was quite difficult.
The example was for sorting a string, and the exact process was as follows:
First, the original string of length 2n is divided into n substrings, each of length 2.
Then sort the n strings in lexicographic order, and then concatenate them to obtain the result string.
Note that the sorting process will be performed on n strings, but not each of the n strings.
The following example illustrates the process: 

abbaaccb → ab ba ac cb → ab < ac < ba < cb → abacbacb

Since the process was quite confusing,
professor Lew decides to use a computer program for verification.
Given an alphabetic string of even length, write a program that prints the result of the sorting process.

###입력
The first line of the input contains one integer T, the number of test cases.
The first line of each test case contains a string. The length of the string will not exceed 1000, and will only contain lowercase alphabet letters.

###출력
For each test case, print the result in one line.

###예제 입력
4
abbaaccb
dddcccbbbaaa
geegeegeegeebabybabybaby
oh

###예제 출력
abacbacb
aababbccdcdd
babababybybyeeeeegeggege
oh