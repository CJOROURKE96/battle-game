int playerHealth = 30;
int enemyHealth = 20;

int playerAttack = 5;
int enemyAttack = 7;

int healAmount = 5;

Random random = new Random();

while(playerHealth > 0 && enemyHealth > 0)
{
    Console.WriteLine("-- Player Turn --");
    Console.WriteLine($"Player health: {playerHealth} Enemy Health: {enemyHealth}");
    Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

    string choice = Console.ReadLine();

    if(choice == "a")
    {
        enemyHealth -= playerAttack;
        Console.WriteLine($"Player attacks the enemy and deals {playerAttack} damage");
    }
    else {
        playerHealth += healAmount;
        Console.WriteLine($"Player has healed by {healAmount} health");
    }

    if(enemyHealth > 0)
    {
        Console.WriteLine("-- Enemy Turn --");
        Console.WriteLine($"Player health: {playerHealth} Enemy Health: {enemyHealth}");

        int enemyChoice = random.Next(0, 2);

        if(enemyChoice == 0)
        {
            playerHealth -= enemyAttack;
            Console.WriteLine($"Enemy attacks the player and deals {enemyAttack} damage");
        }
        else 
        {
            enemyHealth += healAmount;
            Console.WriteLine($"Enemy has healed by {healAmount} health");
        }
    }
}