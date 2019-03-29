using System;

class EntryPoint
{
    static void Main(string[] args)
    {
        // STRINGS ARE IMMUTABLE!!!

        string username = "admin";

        // get char at index
        Console.WriteLine(username[0]);

        // get last char
        Console.WriteLine(username[username.Length - 1]);

    }
}
