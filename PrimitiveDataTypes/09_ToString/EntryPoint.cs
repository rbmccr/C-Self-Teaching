using System;

class EntryPoint
{
    static void Main()
    {
        int bigNumber = 4564532;
        Console.WriteLine(bigNumber.ToString().IndexOf("5"));
        Console.WriteLine(bigNumber.ToString().LastIndexOf("5"));

        string iLearn = "I am learning";
        string nameOfCourse = "C# Mastercourse";
        Console.WriteLine(iLearn + " " + nameOfCourse + " " + bigNumber.ToString());
        // note data types that aren't strings are concatenated without issue,
        // but they aren't coverted to strings unless explicitly called for
        // using the toString() method
    }
}
