## Problem: Subarray with given sum

Given an unsorted array A of size N of non-negative integers, find a continuous sub-array which adds to a given number S.

### Input:
The first line of input contains an integer T denoting the number of test cases. Then T test cases follow. Each test case consists of two lines. The first line of each test case is N and S, where N is the size of array and S is the sum. The second line of each test case contains N space separated integers denoting the array elements.

### Output:
For each testcase, in a new line, print the starting and ending positions(1 indexing) of first such occuring subarray from the left if sum equals to subarray, else print -1.

### Constraints:
1 <= T <= 100
1 <= N <= 107
1 <= Ai <= 1010

### Example:
#### Input:
2

5 12

1 2 3 7 5

10 15

1 2 3 4 5 6 7 8 9 10

### Output:
2 4

1 5

### Explanation :
Testcase1: sum of elements from 2nd position to 4th position is 12

Testcase2: sum of elements from 1st position to 5th position is 15

### Other test sample
### Input:
42 468

135 101 170 125 79 159 163 65 106 146 82 28 162 92 196 143 28 37 192 5 103 154 93 183 22 117 119 96 48 127 172 139 70 113 68 100 36 95 104 12 123 134

### Its Correct output is:
38 42