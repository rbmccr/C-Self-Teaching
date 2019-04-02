using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string fruit = "strawberry";
        string juice = "juice";
        double cost = 10000.55786d;

        Console.WriteLine(fruit);
        Console.WriteLine(juice);

        // right align the strings in the console with
        Console.WriteLine("{0, 15}", fruit);
        Console.WriteLine("{0, 15}", juice);
        // or with [interpolation]
        Console.WriteLine($"{fruit, 15}");
        Console.WriteLine($"{juice, 15}");
        Console.WriteLine($"{cost, 15:C}"); // note change for "currency"
        Console.WriteLine($"{cost, 15:C5}"); // note rounding with "format specifier"
        Console.WriteLine($"{cost, 15:N}"); // note change for "number"

        // challenge
        string spacer = "|======================|"; // can also do new string and use length of "Protein Intake Week: 1"
        // note "d" not mandatory with double nums.
        double[] weeklyIntake = { 
            80.88557,
            94.56465,
            78.67893,
            88.66654,
            88.6466,
            76.777,
            91.85759,
        };

        double total = weeklyIntake.Sum();

        Console.WriteLine("|Protein Intake Week: 1|");
        Console.WriteLine(spacer);
        for (int i = 0; i < weeklyIntake.Length; i++)
        {
            Console.WriteLine($"|{weeklyIntake[i], 22:N2}|");
        }
        Console.WriteLine(spacer);
        Console.WriteLine($"|Total: {total, 15:N2}|");

    }
}