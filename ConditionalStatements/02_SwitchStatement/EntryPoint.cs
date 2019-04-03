using System;

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        string number = Console.ReadLine();

        switch (number)
        {
            case "1":
                Console.WriteLine($"The number is {number}");
                break;
            case "2":
                Console.WriteLine($"The number is {number}");      
                break;
            case "3":
                Console.WriteLine($"The number is {number}");
                break;
            default:
                Console.WriteLine("Unrecognized number!");
                break;
        }
    }
}
