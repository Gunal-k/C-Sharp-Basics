using System.Collections.Generic;

namespace CSharpBasics.Basics;

public class CollectionsDemo
{
    public static void Run()
    {
        List<string> fruits = new()
        {
            "Apple",
            "Banana",
            "Orange"
        };

        fruits.Add("Mango");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}