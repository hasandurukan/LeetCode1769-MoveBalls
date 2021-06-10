
##### LeetCode Problem 1769

## Minimum Number of Operations to Move All Balls to Each Box

You have n boxes. You are given a binary string boxes of length n, where boxes[i] is '0' if the ith box is empty, and '1' if it contains one ball.

In one operation, you can move one ball from a box to an adjacent box. Box i is adjacent to box j if abs(i - j) == 1. Note that after doing so, there may be more than one ball in some boxes.

Return an array answer of size n, where answer[i] is the minimum number of operations needed to move all the balls to the ith box.

Each answer[i] is calculated considering the initial state of the boxes.

 

**Example 1:**

**Input:** boxes = "110"<br/>
**Output:** [1,1,3]<br/>
**Explanation:** The answer for each box is as follows:<br/>
**1)** First box: you will have to move one ball from the second box to the first box in one operation.<br/>
**2)** Second box: you will have to move one ball from the first box to the second box in one operation.<br/>
**3)** Third box: you will have to move one ball from the first box to the third box in two operations, and move one ball from the second box to the third box in one operation.

**Example 2:**

**Input:** boxes = "001011"<br/>
**Output:** [11,8,5,4,3,4]
 

**Constraints:**

n == boxes.length<br/>
1 <= n <= 2000<br/>
boxes[i] is either '0' or '1'.

**Testcase :**
"110"<br/>
"001011"<br/>
"1101111000111011101001"<br/>
"0000000000"<br/>
"11111111"<br/>
"010101010101"<br/>
"111100001100"
