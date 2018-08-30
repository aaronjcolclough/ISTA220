# C# CH 8 HW

1. **What is the diﬀerence between** ***deep copy*** **and** ***shallow copy?***

Shallow copy copies references, deep copy copies the reference as well as any fields that are also references.

2. **What is the value of a reference after you declare and initialize it?**

The memory address of the reference.

3. **How do you declare a value type?**

type name

4. **How do you declare a reference type?**

Type name = new constructor

5. **Does C# allow you to assign NULL to a value type?**

No.

6. **Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?**

No. Because if the nullable value type contains null, then the non-nullable variable cannot contain null.

7. **What is the diﬀerence between the stack and the heap?**

The stack is organized memory and the heap is unorganized memory.

8. **What does it mean when we say that all classes are** ***specialized types?***

Because a class is "concrete" version of type.

9. **What does** ***ref*** **do?**

Passes a reference of the original argument to the method, rather than a copy.

10. **What does** ***out*** **do?**

Allows you to call a method without initializing its argument prior.

11. **Describe** ***boxing*** **and** ***unboxing*** **in your own words.**

Boxing is copying a value to the heap so a reference type can use it. Unboxing is the opposite, using a cast to equate the reference type to a value type.

12. **What does** ***cast*** **do?**

Checks whether converting an item of one type to another is safe before actually making the copy.
