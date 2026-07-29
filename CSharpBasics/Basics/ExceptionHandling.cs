namespace CSharpBasics.Basics;

public class ExceptionHandling
{
    public static void Run()
    {
        try
        {
            int a = 10;
            int b = 0;

            Console.WriteLine(a / b);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Program Finished.");
        }
    }
}