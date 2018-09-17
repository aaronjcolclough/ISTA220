1. **How does inheritance promote the principle of** ***don’t repeat yourself (DRY)*** **?**

It keeps you from having to repeat the same code across multiple classes.

2. **What is the syntax of a derived class that inherits from a base class?**

class derivedclas : baseclass

3. **Do all user deﬁned types (classes and structs) inherit from some base class? If so, what is it?**

No, just classes. Structures inherit from an abstract class named System.ValueType.

4. **What happens if you do not have a default constructor in a base class when creating a derived class?**

if there are zero nondefault constructers, the compiler will generate one. If there are, it will result in a compile-time error.

5. **Can you assign a variable of a derived class to another variable of its base class? Why or why not?**

Yes, so long as the derived class variable is in fact part of the base class.

6. **Can you assign a variable of a derived class to another variable of a derived class of its base class? Why or why not?**

No, because they are not the same.

7. **Can you assign a variable of a base class to another variable of a derived class? Why or why not?**

No, because no all members of the base class exist in the derived class.

8. **Under what circumstances would you want to use the new keyword when deﬁning a method in a derived class?**

"I know what I'm doing, so stop showing me these warnings."

9. **What is a** ***virtual method*** **? Why would you want to deﬁne a virtual method?**

A method that is intended to be overwritten.

10. **What does** ***override*** **do? Why does it do it?**

Declares another implementation of the virtual method. Because the each derived class might need the method in a different way.

11. **How do you deﬁne an** ***extension*** **type?**

In a static class and specify the type to which the method applies as the first parameter to the method with the this keyword.

12. **Why do you deﬁne an** ***extension*** **type?**

To extend a type without affecting existing code.
