using System;

class EntryPoint
{
    static void Main()
    {
        // >, <, ==, >=, <=, !=
        int firstNumber = 5;
        int secondNumber = 10;

        bool firstNumLessThanSecondNum = firstNumber < secondNumber;

        Console.WriteLine(firstNumLessThanSecondNum);
        Console.WriteLine(firstNumber > secondNumber);
        Console.WriteLine(firstNumber <= secondNumber);
        Console.WriteLine(firstNumber >= secondNumber);
        Console.WriteLine(firstNumber == secondNumber);
        Console.WriteLine(firstNumber != secondNumber);
        Console.WriteLine($"Name comparison: { "Todd" == "Todd"}");
    }
}
