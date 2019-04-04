using System;

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine(Perimeter(5, 10, 15, 20)); // sum = 50
    }

    static int Perimeter(params int[] numbers)
    {
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
}
