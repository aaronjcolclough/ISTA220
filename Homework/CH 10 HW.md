1. **What does an array look like in memory?**

A contiguous block of memory on the heap.

2. **Where is memory allocated to hold an array, on the stack or on the heap?**

Both. The stack contains the memory address and the heap contains the values.

3. **Where is memory allocated to hold an array reference, on the stack or on the heap?**

Stack

4. **Can an array hold values of diﬀerent types? This is a trick question, the answer is, “It depends.”**

If the array is reference type, the memory addresses could point to different types.

5. **Describe the syntax of the condition for a** ***foreach*** **loop.**

foreach (variabletype name in arrayname)

6. **How do you make a deep copy of a array?**

By using appropriate code in a for loop.

7. **What is the diﬀerence between a multi-dimensional array and an array of arrays?**

An array of arrays is single dimensional, having multiple memory blocks.

8. **How do you “ﬂatten” a multidimensional array? In other words, take something that looks like a matrix  1 2 3 4 5 6 7 8 9 and turn it into an array [1,2,3,4,5,6,7,8,9]?**

recursion
