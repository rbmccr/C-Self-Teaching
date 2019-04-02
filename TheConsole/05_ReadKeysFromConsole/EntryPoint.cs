using System;
using System.Text;

class EntryPoint
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        // returns a custom data type called ConsoleKeyInfo
        ConsoleKeyInfo key = Console.ReadKey();
        Console.WriteLine();
        // capture key pressed with case sensitivity
        char keyAsChar = key.KeyChar;
        // capture key (not case sensitive)
        Console.WriteLine("The key that was pressed is this one: " + key.Key);
        Console.WriteLine("Modifiers: " + key.Modifiers); // not returned in order of key press
    }
}