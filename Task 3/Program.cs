public class ParameterDemo
{
    public void Increase(ref int number)
    {
        number = number + 10;
    }

    public void GetFullName(out string fullname)
    {
        fullname = "Agraz Adhikari";
    }

    public int SumAll(params int[] numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum = sum + number;
        }

        return sum;
    }

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

        Console.WriteLine("Sum: " + total);
    }
}