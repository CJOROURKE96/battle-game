int playerHealth = 30;
int enemyHealth = 20;

int playerAttack = 5;
int enemyAttack = 7;

int healAmount = 5;

while(playerHealth > 0 && enemyHealth > 0)
{
    Console.WriteLine("-- Player Turn --");
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
}