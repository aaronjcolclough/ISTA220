1. **What is the diﬀerence between a property and a ﬁeld?**

A property acts like a method; the compiler automatically translates the syntax into calls to accessor methods.

2. **What is the diﬀerence between a property and a method?**



3. **What is your understanding of encapsulation?**

Using properties to keep data private.

4. **Some languages are case insensitive, that is, an "a" and an "A" are considered to be the same letter. C# is case sensitive. What implications does this have regarding the naming of variables, methods, and other identiﬁers? Do you think that the diﬀerence in case in the initial character of two diﬀerent identiﬁers is suﬃcient to distinguish them?**

You can give the same name to multiple entities if they differ in case. Yes, so long as you are aware of the naming methodology; however, it can lead to logic errors because of how similar the names are.

5. **Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use a write-only property.**

Pi. Secure data.

6. **Can you think of a reason why you might ever want to make getters and setters private? Give an example. Also, make a case why getters and setters should never be private.**

When you don't want people to change anything. Internal processes.

7. **What are restrictions on the use of properties?**

can't use as a ref or an out argument, can contain one get accessor and one set accessor which cannot take any parameters, ,can't declare by using const.

8. **What is an object initializer? What is the syntax for an object initializer?**

The syntax used to initialize an instance of a class by specifying the names and values for any public properties that have set accessors.
