namespace CSharpBasics.Basics;

public class StringsDemo
{
    public static void Run()
    {
        string name = "Guna";

        Console.WriteLine(name.ToUpper());
        Console.WriteLine(name.ToLower());
        Console.WriteLine(name.Length);
        Console.WriteLine(name.Contains("un"));
        Console.WriteLine(name.Replace("G", "K"));
    }
}