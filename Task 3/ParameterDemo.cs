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
}