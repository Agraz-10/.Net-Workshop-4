public class Task5
{
    public enum DayType
    {
        Weekday,
        Weekend
    }

    public record Book(string title, string author, double price);

    public static void Main(string[] args)
    {
        Console.Write("Enter a day: ");
        string day = Console.ReadLine();

        DayType dayType;

        if (day.ToLower() == "friday" || day.ToLower() == "saturday")
        {
            dayType = DayType.Weekend;
        }
        else
        {
            dayType = DayType.Weekday;
        }

        Console.WriteLine("It is: " + dayType);

        Book book1 = new Book("Rich Dad Poor Dad", "Robert Kiyosaki", 500);

        Book book2 = book1 with
        {
            title = "Atomic Habits",
            price = 800
        };

        Console.WriteLine("\nFirst Book:");
        Console.WriteLine(book1);

        Console.WriteLine("\nSecond Book:");

        var (title, author, price) = book2;

        Console.WriteLine("Title: " + title);
        Console.WriteLine("Author: " + author);
        Console.WriteLine("Price: " + price);
    }
}