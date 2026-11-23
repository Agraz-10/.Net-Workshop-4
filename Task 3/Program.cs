public class Program
{
    public static void Main(string[] args)
    {
        ParameterDemo obj = new ParameterDemo();

        int number = 20;

        obj.Increase(ref number);

        Console.WriteLine("Increased Number: " + number);

        string fullname;

        obj.GetFullName(out fullname);

        Console.WriteLine("Full Name: " + fullname);

        int total = obj.SumAll(10, 20, 30, 40);

        Console.WriteLine("Total Sum: " + total);
    }
}