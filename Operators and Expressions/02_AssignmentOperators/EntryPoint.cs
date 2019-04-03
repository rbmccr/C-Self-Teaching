using System;

class EntryPoint
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;

        firstNumber += secondNumber;
        Console.WriteLine(firstNumber);
        firstNumber -= secondNumber;
        Console.WriteLine(firstNumber);
        firstNumber *= secondNumber;
        Console.WriteLine(firstNumber);
        firstNumber /= secondNumber;
        Console.WriteLine(firstNumber);
    }
}