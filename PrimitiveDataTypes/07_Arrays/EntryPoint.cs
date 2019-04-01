using System;

class EntryPoint
{
    static void Main()
    {
        int[] numbers = { 5, 5, 6, 7, 3, 4, 5, 6 };

        Console.WriteLine(numbers[3]);
        Console.WriteLine(numbers[numbers.Length - 1]);

        // another way to make an array (all valiues are 0)
        // cannot ever add more elements to array beyond num specified
        int[] moreNumbers = new int[8];
        moreNumbers[2] = 100;
        Console.WriteLine(moreNumbers);

        string[] fruits = new string[2];
        fruits[0] = "oranges";
        fruits[1] = "bananas";
        Console.WriteLine(fruits[0] + fruits[1]);
    }
}