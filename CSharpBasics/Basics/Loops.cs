namespace CSharpBasics.Basics;

public class Loops
{
    public static void Run()
    {
        Console.WriteLine("For Loop");

        for (int i = 1; i <= 5; i++)
            Console.WriteLine(i);

        Console.WriteLine("\nWhile Loop");

        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine(j);
            j++;
        }

        Console.WriteLine("\nDo While");

        int k = 1;
        do
        {
            Console.WriteLine(k);
            k++;
        } while (k <= 5);
    }
}