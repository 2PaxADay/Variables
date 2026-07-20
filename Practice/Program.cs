
Console.OutputEncoding = System.Text.Encoding.UTF8;  // koristimo pre celog koda da bi smo mogli da koristimo emojije, ne funkcionise na starije sisteme kao windows 7,8

Console.WriteLine("\"Dungeon Crawler\"");

// Ovde je mali test printovanja i spajanja varijabila sa consolewriteline

Console.WriteLine("Welcome Hero! What is your name?");
string hero = Console.ReadLine();
int level = 0;

Console.WriteLine($"welcome {hero}! Your level is {level}!");

Random dice = new Random();
int goblinHealth = 50;
int attackDamage = 15;
int healAmount = 5;

Console.WriteLine($"You're approached by a shady Goblin,his health is {goblinHealth}. What do you wish to do?");

while (goblinHealth > 0 && goblinHealth < 100)
{
    Console.WriteLine("⚔️ 1 - Attack him?");
    Console.WriteLine("♥️ 2 - Heal him?");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        int momentaryDamage = dice.Next(-5, 5);
        goblinHealth -= attackDamage + momentaryDamage;
        Console.WriteLine($"You've dealt {attackDamage + momentaryDamage} to the Goblin! His health is now {goblinHealth}");
    }
    else if (choice == "2")
    {
        int momentaryHeal = dice.Next(-3, 6);
        goblinHealth += healAmount + momentaryHeal;
        Console.WriteLine($"You've healed the Goblin for {healAmount+ momentaryHeal}! His health is now {goblinHealth}");
    }
    else
    {
        Console.WriteLine("You chose to stare at him, the Goblin stares back at you confused 😵‍💫"); // In this case we get this result if we input anything other than 1 or 2 because we left the readline open while giving the choice.
    }

}

if (goblinHealth <= 0)
{
    Console.WriteLine("☠️ You've slain the Goblin! Your reward is 100 coins");
}
else if (goblinHealth >= 100)
{
    Console.WriteLine("🧟‍♂️ You've healed the Goblin to his full health! He is now your companion!");
}
