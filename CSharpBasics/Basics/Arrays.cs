namespace CSharpBasics.Basics;

public class ArraysDemo
{
    public static void Run()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}