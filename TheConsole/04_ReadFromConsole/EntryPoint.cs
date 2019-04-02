using System;

class EntryPoint
{
    static void Main()
    {
        // capture a single character from input
        // note that age will be reported based on ASCII decimal code
        // if not char typecast is provided

        //Console.Write("How old are you?");
        //char age = (char)Console.Read();
        //Console.WriteLine($"My age is: {age}");

        // use Console.ReadLine to get more information
        //Console.Write("How old are you?");
        //int age = int.Parse(Console.ReadLine()); // note string needs to be converted or parsed
        //Console.WriteLine($"My age is: {age}");

        // challenge (input: D, Microsoft, Word.exe)
        Console.Write("Input the drive letter: ");
        string drive = Console.ReadLine();
        Console.Write("Input the folder path: ");
        string path = Console.ReadLine();
        Console.Write("Input the drive letter: ");
        string file = Console.ReadLine();
        Console.WriteLine($"{drive}:\\{path}\\{file}");
    }
}
