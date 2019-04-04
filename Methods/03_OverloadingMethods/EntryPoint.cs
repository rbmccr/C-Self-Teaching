using System;

class EntryPoint
{
    static void Main()
    {
        // overloading means that you can have multiple methods of the
        // same name, and each method has a different signature (args)
        // and can perform something extra beyond the other methods
        PrintNames("R", "M");
        PrintNames("R", "B", "M");
        PrintNames("R", "B", ConsoleColor.Red);
    }

    static void PrintNames(string first, string last)
    {
        Console.WriteLine($"My initials are {first} {last}");
    }

    static void PrintNames(string first, string middle, string last)
    {
        Console.WriteLine($"My initials are {first} {middle} {last}");
    }

    static void PrintNames(string first, string last, ConsoleColor color)
    {
        Console.Write("My colorful initials are ");
        Console.ForegroundColor = color;
        Console.Write($"{first} {last}\n");
        Console.ResetColor();
    }
}