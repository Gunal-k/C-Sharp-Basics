using CSharpBasics.Basics;
using CSharpBasics.Projects;

Console.WriteLine("Choose Folder:");
Console.WriteLine("1. Basics");
Console.WriteLine("2. Projects");

string? choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.WriteLine("\nChoose a lesson:");
        Console.WriteLine("1. Variables");
        Console.WriteLine("2. Operators");

        string? ch = Console.ReadLine();
        Console.WriteLine();

        switch(ch)
        {
            case "1":
                Variables.Run();
                break;

            case "2":
                Operators.Run();
                break;
        }
        break;
        
    case "2":
        Console.WriteLine("\nChoose a Project:");
        Console.WriteLine("1. Calculate Print Student Grades");
        Console.WriteLine("2. Calculate Final GPA");
        Console.WriteLine("3. Arrays Iteration Selection");
        Console.WriteLine("4. Arrays Iteration Selection 2");
        
        string? ch2 = Console.ReadLine();
        Console.WriteLine();

        switch (ch2)
        {
            case "1":
                CalculatePrintStudentGrades.Run();
                break;
            
            case "2":
                CalculateFinalGpa.Run();
                break;
            
            case "3":
                ArraysIterationSelection.Run();
                break;
            
            case "4":
                ArraysIterationSelection2.Run();
                break;
        }
        break;

    default:
        Console.WriteLine("Invalid choice");
        break;
}