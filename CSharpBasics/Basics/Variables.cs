namespace CSharpBasics.Basics;

public class Variables
{
    public static void Run()
    {
        Console.WriteLine("=== Variables ===");

        string name = "Guna";
        int age = 21;
        double height = 5.9;
        char grade = 'A';
        bool isStudent = true;

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine($"Student: {isStudent}");
    }
}