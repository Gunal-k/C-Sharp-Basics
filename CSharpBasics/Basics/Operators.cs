namespace CSharpBasics.Basics;

public class Operators
{
    public static void Run()
    {
        Console.WriteLine("=== Operators ===");

        int a = 10;
        int b = 3;

        Console.WriteLine($"Addition: {a + b}");
        Console.WriteLine($"Subtraction: {a - b}");
        Console.WriteLine($"Multiplication: {a * b}");
        Console.WriteLine($"Division: {a / b}");
        Console.WriteLine($"Modulus: {a % b}");

        Console.WriteLine($"a > b : {a > b}");
        Console.WriteLine($"a == b : {a == b}");

        Console.WriteLine($"a && b : {(a > 5 && b < 5)}");
    }
}