1. **Give ﬁve examples (using valid C# code) of the ﬁve bitwise operators listed in the text.**

~1     00000001 becomes 11111110
1 << 2     00000001 becomes 00000100
1 >> 2   00000001 becomes 00000000
1 | 3     00000001 becomes 00000011
1 ^ 3     00000001 becomes 00000010
1 & 3     00000001 becomes 00000001

2. **Does C# implement the right-shift (>>) operator? If so, give an example of its operation using valid C# code.**

Yes. 1 >> 2    00000001 becomes 00000000

3. **Explain in detail this code: bits & (1 << index);.**

turns all the numbers to zero except the bits in both numbers (bits, (1 << index)) that both contain 1

4. **Explain in detail this code: bits |= (1 << index);.**

turning a bit on in the bits variable based on an index number and setting bits equal to it

5. **Explain in detail this code: bits &= (1 << index);.**

turning a bit off in the bits variable based on an index number and setting bits equal to it

6. **How does C# interpret this? bool peek = bits[n];**

true or false; whether or not the bit is turned on or off

7. **How does C# interpret this? bits[n] = true;**

sets the bit to 1

8. **How does C# interpret this? bits[n] ^= true;**

sets the bit to (bits[n] ^ true)

9. **Assume that users were assigned read, write, and execute permissions according to this scheme: read = 4, write = 2, execute = 1. How would you interpret the following user permissions:
(a) permission = 0 (b) permission = 1 (c) permission = 2 (d) permission = 3 (e) permission = 4 (f) permission = 5 (g) permission = 6 (h) permission = 7**

a- no permissions b- execute c- write d- write & execute e- read f- read & execute g- read & write h- read, write & execute

10. **Answer the previous question by converting the decimal permissions into binary permissions. What does this tell you about using this scheme of permissions?**

the permissions are based on whether or not the first three bits are turned on or not
