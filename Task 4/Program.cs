public class Program
{
    public static void Main(string[] args)
    {
        Player p1 = new Player();

        p1.playerName = "Agraz";
        p1.level = 1;
        p1.health = 100;

        Player p2 = new Player("Prajwal", 5, 80);

        Console.WriteLine("\nPlayer 1 Details:");
        Console.WriteLine("Name: " + p1.playerName);
        Console.WriteLine("Level: " + p1.level);
        Console.WriteLine("Health: " + p1.health);

        Console.WriteLine("\nPlayer 2 Details:");
        Console.WriteLine("Name: " + p2.playerName);
        Console.WriteLine("Level: " + p2.level);
        Console.WriteLine("Health: " + p2.health);
    }
}