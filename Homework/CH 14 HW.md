1. **What is the diﬀerence between a** ***managed*** **resource and an** ***unmanaged*** **resource?**

Unmanaged resources are finite and costly.

2. **When is memory for an object (reference type) allocated? When is the memory deallocated?**

When it's needed. When it's out of scope.

3. **What is a** ***destructor?***

A special method that the CLR calls after the reference to an object has disappeared.

4. **What is the diﬀerence in syntax between a constructor and a destructor?**

~name()

5. **Give some examples of scarce resources. Why would you want to manage scarce resources?**

Memory, database connections, file handles. So you don't have to wait for the garbage collector to release them.

6. **What is** ***exception-safe*** **disposal?**

Using a finally block to ensure that a disposal method is always called.

7. **How do you think that the using statement works for resource management? Give an informal, English language, explanation of how it works.**

Separates functionality from implementation.

8. **What ill eﬀects could result from attempting to dispose of a resource more than once?**

Wasted process and data loss.

9. **We will look at threads later in the term. For now, what is your understanding of how threads interact with resource management? A good guess is a sufficient answer to this question.**

Next Term.

10. **Why does the book recommend not attempting to force the garbage collector? Are their any exceptions to this recommendation?**

Loss of data.
