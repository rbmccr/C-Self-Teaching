using System;

class EntryPoint
{
    static void Main()
    {
        Console.Title = "My App"; // upper left title of console window
        Console.CursorVisible = true; // false for invisible
        Console.CursorSize = 100; // height of cursor within row
        Console.SetCursorPosition(50, 20); // space above and left of cursor
    }
}