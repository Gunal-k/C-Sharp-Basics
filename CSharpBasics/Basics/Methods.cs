namespace CSharpBasics.Basics;

public class MethodsDemo
{
    public static void Run()
    {
        Greet("Guna");

        int result = Add(10, 20);
        Console.WriteLine(result);
    }

    static void Greet(string name)
    {
        Console.WriteLine($"Hello {name}");
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}