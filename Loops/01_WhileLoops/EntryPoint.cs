using System;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        // while loop
        int number = 0;
        int min = 20;
        int max = 30;
        bool numberInRange = false;
        while (!numberInRange)
        {
            Console.WriteLine($"Please input a number between {min} and {max}.");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= min && number <= max)
            {
                numberInRange = true;
                Console.WriteLine($"Correct!");

            }
            else
            {
                Console.WriteLine($"Incorrect. Please input a number between {min} and {max}.");
                // pause the program for 2 seconds
                Thread.Sleep(2000);
                Console.Clear();
            }
        }

        // do while loop (always runs at least once)
        int startNum = 0;
        int endNum = 100;

        Random addThisNum = new Random();

        do
        {
            Console.WriteLine(startNum);
            // add a number (between 10 and 20) to the startNum
            startNum += addThisNum.Next(10, 20);
        } while (startNum <= endNum);

        Console.WriteLine(startNum);
    }
}
