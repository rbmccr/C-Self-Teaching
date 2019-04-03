using System;

class EntryPoint
{
    static void Main()
    {
        // control console window size
        Console.WindowHeight = 40;
        Console.WindowWidth = 50;
        Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

        // control scrollable area beyond dimensions of console
        // must be >= window size
        // equaling the window size removes scroll bars
        Console.BufferHeight = 200;
        Console.BufferWidth = 2000;
        //Console.SetBufferSize(40, 55);

        // control starting position of scroll
        // must be smaller than (buffer - window size)
        Console.WindowTop = 10;
        Console.WindowLeft = 10;
        //Console.SetWindowPosition(10, 10);
    }
}