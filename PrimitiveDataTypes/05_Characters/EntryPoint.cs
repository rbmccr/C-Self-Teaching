using System;
using System.Text;

class EntryPoint
{
    static void Main()
    {
        // must be once character in SINGLE QUOTES
        char theCharacterX = 'x';
        Console.WriteLine(theCharacterX);

        // use ASCII table to create symbols with char data type

        // Hx code
        char thePlusSign = '\u002B';
        Console.WriteLine(thePlusSign);

        // use unicode
        Console.InputEncoding = Encoding.UTF8;
        char theLetterOWithDots = '\u00F6';
        Console.WriteLine(theLetterOWithDots);
    }
}
