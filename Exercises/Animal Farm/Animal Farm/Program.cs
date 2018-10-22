using System;

namespace Animal_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my farm, what do you want to see first?");            
            optionmenu();
        }

        private static void optionmenu()
        {
            Console.WriteLine("I have a wolverine, a beast, a sabertooth, and a toad");
            string menu = Console.ReadLine();            

            if (menu.ToLower() == "wolverine")
            {
                Wolverine James = new Wolverine();                
                able(James);
            }
            else if (menu.ToLower() == "beast")
            {
                Beast Hank = new Beast();
                able(Hank);
            }
            else if (menu.ToLower() == "sabertooth")
            {
                Sabertooth Victor = new Sabertooth();
                able(Victor);
            }
            else if (menu.ToLower() == "toad")
            {
                Toad Mortimer = new Toad();                
                able(Mortimer);
            }
            else
            {
                Console.WriteLine("I don't have that here. Try again.");
                optionmenu();
            }
        }

        private static void able(Animal animal)
        {
            Console.WriteLine($"What would you like {animal.name()} to do? He can speak, drink, fight, and rest.");
            string action = Console.ReadLine();

            if (action.ToLower() == "speak")
            {
                Console.WriteLine($"{animal.name()}: {animal.speak()}");
                choice(animal);                
            }
            else if (action.ToLower() == "drink")
            {
                Console.WriteLine($"{animal.name()}: {animal.drink()}");
                choice(animal);                
            }
            else if (action.ToLower() == "fight")
            {
                Console.WriteLine($"{animal.name()}: {animal.fight()}");
                choice(animal);                
            }
            else if (action.ToLower() == "rest")
            {
                Console.WriteLine($"{animal.name()}: {animal.rest()}");
                choice(animal);
            }
            else
            {
                Console.WriteLine("He can't do that. Try again.");
                able(animal);
            }
        }

        private static void choice(Animal animal)
        {
            Console.WriteLine("Do you want to see him do anything else?");
            string ans = Console.ReadLine();

            if (ans.ToLower() == "yes")
            {
                able(animal);
            }
            else if (ans.ToLower() == "no")
            {
                Console.WriteLine("What do you want to see next?");
                optionmenu();
            }
            else
            {
                Console.WriteLine("That doesn't even make sense. What do you want to see next?");
                optionmenu();
            }
        }
    }
}
