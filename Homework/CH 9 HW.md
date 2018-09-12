1. **Declare an enum for military ranks, either oﬃcer or enlisted. Name it Ranks. What are the symbols, like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?**

enum Rank { PVT, PV2, PFC, SPC, SGT, SSG, SFC, MSG, CSM }

2. **Using the Ranks enum, assign a rank to yourself or a friend.**

Rank me = Rank.SSG;

3. **Determine the numeric index of particular ranks, using the Ranks enum.**

{ PVT, PV2, PFC, SPC, SGT, SSG, SFC, MSG, CSM } = { 0, 1, 2, 3, 4, 5, 6, 7, 8 }

Rank me = Rank.SSG;
Console.WriteLine((int)me); // writes '5'

4. **How do you select the type of an enum?**

enum Rank : short { PVT, PV2, PFC, SPC, SGT, SSG, SFC, MSG, CSM }

5. **Are structs stored on the stack or on the heap? What about enums?**

Both are stored on the stack.

6. **Declare a struct named DOD with four branches.**

struct DOD
{
  private string army, navy, airforce, marines;
}

7. **Why can’t you create a default constructor for a struct?**

Because the compiler always generates one for a struct.

8. **What is CIL? What does the CLR do to the CIL?**

A "pseudo-machine code" that are stored in an assembly. The CLR converts the CIL in instructions your computer can understand and execute.
