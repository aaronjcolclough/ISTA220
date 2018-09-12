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
                object speak = James.speak();
                object drink = James.drink();
                object fight = James.fight();
                object rest = James.rest();
                string name = James.name;
                able(speak, drink, fight, rest, name);
            }
            else if (menu.ToLower() == "beast")
            {
                Beast Hank = new Beast();
                object speak = Hank.speak();
                object drink = Hank.drink();
                object fight = Hank.fight();
                object rest = Hank.rest();
                string name = Hank.name;
                able(speak, drink, fight, rest, name);
            }
            else if (menu.ToLower() == "sabertooth")
            {
                Sabertooth Victor = new Sabertooth();
                object speak = Victor.speak();
                object drink = Victor.drink();
                object fight = Victor.fight();
                object rest = Victor.rest();
                string name = Victor.name;
                able(speak, drink, fight, rest, name);
            }
            else if (menu.ToLower() == "toad")
            {
                Toad Mortimer = new Toad();
                object speak = Mortimer.speak();
                object drink = Mortimer.drink();
                object fight = Mortimer.fight();
                object rest = Mortimer.rest();
                string name = Mortimer.name;
                able(speak, drink, fight, rest, name);
            }
            else
            {
                Console.WriteLine("I don't have that here. Try again.");
                optionmenu();
            }
        }

        private static void able(object speak, object drink, object fight, object rest, string name)
        {
            Console.WriteLine($"What would you like {name} to do? He can speak, drink, fight, and rest.");
            string action = Console.ReadLine();

            if (action.ToLower() == "speak")
            {
                Console.WriteLine($"{name}: {speak}");
                choice(speak, drink, fight, rest, name);                
            }
            else if (action.ToLower() == "drink")
            {
                Console.WriteLine($"{name}: {drink}");
                choice(speak, drink, fight, rest, name);                
            }
            else if (action.ToLower() == "fight")
            {
                Console.WriteLine($"{name}: {fight}");
                choice(speak, drink, fight, rest, name);                
            }
            else if (action.ToLower() == "rest")
            {
                Console.WriteLine($"{name}: {rest}");
                choice(speak, drink, fight, rest, name);
            }
            else
            {
                Console.WriteLine("He can't do that. Try again.");
                able(speak, drink, fight, rest, name);
            }
        }

        private static void choice(object speak, object drink, object fight, object rest, string name)
        {
            Console.WriteLine("Do you want to see him do anything else?");
            string ans = Console.ReadLine();

            if (ans.ToLower() == "yes")
            {
                able(speak, drink, fight, rest, name);
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
