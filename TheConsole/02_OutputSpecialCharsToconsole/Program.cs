using System;

class Program
{
    static void Main()
    {
        string exeFile = "Word.exe";
        // must use escape \ to include special characters
        string pathToExe = "\"C:\\Program Files\\Microsoft Word\\\"";
        // can also use @ symbol in front of string with no escape \,
        // but with quotation marks to escape themselves
        string pathToExe2 = @"""C:\Program Files\Microsoft Word\""";
        Console.WriteLine(pathToExe);
        Console.WriteLine(pathToExe2);
        // to use interpolation and include the {}, escape with {{}}
        Console.WriteLine($"{pathToExe}{exeFile}");
    }
}
