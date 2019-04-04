using System;

class EntryPoint
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7 };

        // for loop
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

        // foreach loop        
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}

