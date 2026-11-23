public class Calculator
{
    public void PrintWelcome()
    {
        Console.WriteLine("Welcome to the Calculator");
    }

    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Multiply(int num1, int num2 = 1)
    {
        return num1 * num2;
    }

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