public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter obtained marks: ");
        int.TryParse(Console.ReadLine(), out int marks);

        Console.Write("Enter total marks: ");
        int.TryParse(Console.ReadLine(), out int total);

        Percentage obj = new Percentage();

        double result = obj.CalculatePercentage(marks, total);

        Console.WriteLine("Percentage: " + result);
    }
}