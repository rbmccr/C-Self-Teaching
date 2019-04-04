using System;

class EntryPoint
{
    static void Main()
    {
        PrintingNames("Brendan", ConsoleColor.Red);
        PrintingNames("Patrick", ConsoleColor.Green);
    }

    // void methods are expected to do something but return no result
    static void PrintingNames(string name, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine($"My name is {name}.");
        Console.ResetColor();
    }
}