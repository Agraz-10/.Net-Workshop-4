public class Program
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        calc.PrintWelcome();

        int sum = calc.Add(10, 20);
        Console.WriteLine("Addition: " + sum);

        int result1 = calc.Multiply(5);
        Console.WriteLine("Multiplication: " + result1);

        int result2 = calc.Multiply(5, 3);
        Console.WriteLine("Multiplication: " + result2);
    }
}