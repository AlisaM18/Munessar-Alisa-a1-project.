// Begin story, enter first prompt
using System;
class Program
{
    static void Main()

    {
        Console.WriteLine("Your journey begins, traveler. Would you like to enter the portal?");
        // Tell player of their options
        Console.WriteLine("Type Yes to enter the portal, or No to avoid it.");
        //Get the players response
        string response = Console.ReadLine().Trim().ToLower();
        // Player's response
        // If yes, the continue
        // If no, the game ends 
        if (response == "yes")
        {
            Console.WriteLine("You have entered the portal, and there are dazzling weapons before you");
            Console.WriteLine("Which will you take?");
        }
        //Else if no, game ends
        else if (response == "no")
        {
            Console.WriteLine("Game Over. Maybe try yes this time.");
            return;
        }
        // Invalid response
        else
        {
            Console.WriteLine("invalid response");
            return;
        }
        // Ask player which weapon they want
        Console.WriteLine("A Sword, a Shield, or a Dagger?");
        Console.WriteLine("Type Sword, Shield or Dagger");
        //Get player's response to choose a weapon
        string weapon = Console.ReadLine().Trim().ToLower();
        //If sword, indicate they choose the sword
        int strength = 5;
        bool hasSword = false;

        int defense = 3;
        bool hasShield = false;

        int speed = 3;
        bool hasSpeed = false;

        if (weapon == "sword")
        {
            hasSword = true;
            strength += 10;
            Console.WriteLine("You have chosen the sword, a fine choice for a warrior.");
            Console.WriteLine($"Your strength is now {strength}");
        }
        //Else if shield, indicate they chose the shield

        else if (weapon == "shield")
        {
            hasShield = true;
            defense += 5;
            Console.WriteLine("You have chosen the shield, a fine choice for a defender.");
            Console.WriteLine($"Your defense is now {defense}");
        }
        // Else if dagger, indicate they choose the dagger

        else if (weapon == "dagger")
        {
            hasSpeed = true;
            speed += 3;
            Console.WriteLine("You have chosen the dagger, a fine choice for a rogue.");
            Console.WriteLine($"Your speed is now {speed}");
        }
        //Else, indicate invalid option
        else
        {
            Console.WriteLine("invalid response");
            return;
        }
        //Indicate next steps to the plot
        Console.WriteLine("You grab your weapon and continue into a deep forest. The sun is blacked out by the thick trees, and you hear rustling in the nearby bushes.");
        Console.WriteLine("Suddenly, a disfigured rabbit appears. What do you do?");
        //Tell player of their options
        Console.WriteLine("Type Pet to pet the rabbit, or Fight to attack it.");
        //Get player's response
        string action = Console.ReadLine().Trim().ToLower();
        //If pet, indicate they pet the rabbit and it bites them
        if (action == "pet")
        {
            Console.WriteLine("You Pet the rabbit, it gets angry and attacks you. Game Over.");
            return;
        }
        //Else if fight, indicate they fight the rabbit and move on
        else if (action == "fight")
        {
            Console.WriteLine("You bravely fight the rabbit and it runs away.");
        }
        //else, indicate invalid option
        else
        {
            Console.WriteLine("invalid response");
            return;
        }
        //Indicate next steps to the plot
        Console.WriteLine("You successfully deter the rabbit and continue on. Eventually you come to an open path with more Portals. One red, one blue, and one green. Which do you choose?");
        //Tell player of their options
        Console.WriteLine("Type Red, Blue, or Green to choose a portal.");
        //Get player's response
        string portal = Console.ReadLine().Trim().ToLower();
        //If red, indicate they enter the red portal
        if (portal == "red")
        {
            Console.WriteLine("You have entered the Fire world!");
        }
        //If blue, indicate they enter the blue portal
        else if (portal == "blue")
        {
            Console.WriteLine("You have entered the Water world!");
        }
        //if green, indicate they enter the green portal
        else if (portal == "green")
        {
            Console.WriteLine("You have entered the Earth world!");
        }
        //Else, indicate invalid option
        else
        {
            Console.WriteLine("Invalid Response");
            return;
        }
    }
}
