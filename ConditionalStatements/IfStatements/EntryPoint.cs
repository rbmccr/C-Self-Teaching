using System;

class EntryPoint
{
    static void Main()
    {
        // challenge
        Console.WriteLine("Enter a username: ");
        string tempUsername = Console.ReadLine();

        string username = string.Empty;

        if (tempUsername == "admin")
        {
            Console.WriteLine("Username cannot be 'admin'");
        }
        else
        {
            Console.WriteLine("Username accepted");
            username = tempUsername;
        }

        Console.WriteLine($"username = {username}");

        // challenge
        // Write an expression to check if the hundred's place of an int is 3
        // e.g. 5352
        Console.WriteLine("Enter a number: ");
        string number = Console.ReadLine();
        if (number.Length >= 3 && number[number.Length - 3] == '3') // note char data type comparison
        {
            Console.WriteLine("IT'S '3'");
        }
        else
        {
            Console.WriteLine("NOT '3'");
        }

        // challenge
        // write an expression that checks if a given point (x, y)
        // is within a circle with radius 4 and center (0, 0)
        Console.WriteLine("Enter a number x: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number y: ");
        int y = int.Parse(Console.ReadLine());

        int radius = 4;
        double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        Console.WriteLine($"Distance = {distance}");

        if (distance < (double)radius)
        {
            Console.WriteLine("The point is WITHIN the circle!");
        }
        else if (distance == 4.0)
        {
            Console.WriteLine("The point is on the circle itself.");
        }
        else
        {
            Console.WriteLine("The point NOT in the circle.");
        }

    }
}

