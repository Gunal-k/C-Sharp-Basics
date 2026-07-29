using CSharpBasics.Basics;
using CSharpBasics.Projects;

Console.WriteLine("Choose a lesson:");
Console.WriteLine("1. Variables");
Console.WriteLine("2. Operators");
Console.WriteLine("3. Project1");
Console.WriteLine("4. Project2");


string? choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Variables.Run();
        break;

    case "2":
        Operators.Run();
        break;

    case "3":
        CalculatePrintStudentGrades.Run();
        break;
    
    case "4":
        CalculateFinalGpa.Run();
        break;

    default:
        Console.WriteLine("Invalid choice");
        break;
}