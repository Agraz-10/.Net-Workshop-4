public class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();

        s1.Name = "Agraz Adhikari";
        s1.Course = "Bsc(Hons) Computing";
        s1.Age = 20;

        Student s2 = new Student();

        s2.Name = "Prajwal Kafle";
        s2.Course = "Bsc(Hons) Business";
        s2.Age = 16;

        Console.WriteLine("Student 1 Details:");
        Console.WriteLine(s1.Name);
        Console.WriteLine(s1.Age);
        Console.WriteLine(s1.Course);

        Console.WriteLine("\nStudent 2 Details:");
        Console.WriteLine(s2.Name);
        Console.WriteLine(s2.Age);
        Console.WriteLine(s2.Course);

        Console.WriteLine("\nCollege: " + Student.college);
    }
}