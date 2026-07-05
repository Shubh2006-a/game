using System;

class Program
 dungeon
{
    static void Main(string[] args)
    {
        // Game Setup
        string gameTitle = "The Forgotten Crypt";
        Console.Title = gameTitle;
        
        // Introduction
        Console.WriteLine($"=== Welcome to {gameTitle} ===");
        Console.WriteLine("You wake up in a cold, stone room. A single torch flickers on the wall.");
        Console.WriteLine("In front of you are two doors: one to the LEFT and one to the RIGHT.");
        
        // First Choice
        Console.Write("\nWhich door do you choose? (Type LEFT or RIGHT): ");
        string choice1 = Console.ReadLine().ToUpper().Trim();

        Console.Clear();

        if (choice1 == "LEFT")
        {
            // Left Path: The Goblin Room
            Console.WriteLine("You step into a damp room and come face-to-face with a sleeping Goblin!");
            Console.WriteLine("Next to the goblin is a shiny GOLDEN KEY.");
            Console.WriteLine("Do you try to SNEAK past and grab the key, or ATTACK the goblin?");
            
            Console.Write("\nWhat do you do? (Type SNEAK or ATTACK): ");
            string choice2 = Console.ReadLine().ToUpper().Trim();

            Console.Clear();

            if (choice2 == "SNEAK")
            {
                Console.WriteLine("Success! You quietly grab the golden key and slip through the back door.");
                Console.WriteLine("The key unlocks the main castle gates. YOU ESCAPED! YOU WIN!");
            }
            else if (choice2 == "ATTACK")
            {
                Console.WriteLine("You charge at the goblin, but you don't have a weapon!");
                Console.WriteLine("The goblin wakes up, defends itself, and defeats you. GAME OVER.");
            }
            else
            {
                Console.WriteLine("You hesitated for too long. The goblin woke up and caught you! GAME OVER.");
            }
        }
        else if (choice1 == "RIGHT")
        {
            // Right Path: The Riddle Room
            Console.WriteLine("You enter a brightly lit room. A massive stone Sphinx blocks your path.");
            Console.WriteLine("The Sphinx speaks: 'I speak personally, but have no tongue. I hear everything, but have no ears. What am I?'");
            
            Console.Write("\nYour answer: ");
            string riddleAnswer = Console.ReadLine().ToUpper().Trim();

            Console.Clear();

            if (riddleAnswer == "AN ECHO" || riddleAnswer == "ECHO")
            {
                Console.WriteLine("The Sphinx smiles and steps aside, revealing a portal made of pure light.");
                Console.WriteLine("You step through the portal and find yourself back home. YOU WIN!");
            }
            else
            {
                Console.WriteLine($"'{riddleAnswer}' is incorrect! The Sphinx growls and traps you in the room forever. GAME OVER.");
            }
        }
        else
        {
            // Invalid Choice
            Console.WriteLine("You stood still in the dark for too long, and the torch went out. GAME OVER.");
        }

        // End of Game
        Console.WriteLine("\nThank you for playing!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}