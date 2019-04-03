using System;

class EntryPoint
{
    static void Main()
    {
        int firstNumber = 5;
        int secondNumber = 10;
        int thirdNumber = 15;

        int addition = firstNumber + secondNumber;
        int subtraction = firstNumber - secondNumber;
        int multiplication = firstNumber * secondNumber;
        double division = (double)firstNumber / (double)secondNumber; // typecast integers

        Console.WriteLine(addition);
        Console.WriteLine(subtraction);
        Console.WriteLine(multiplication);
        Console.WriteLine(division);

        // pay attention to operations parenthesis
        int equation = firstNumber * secondNumber - thirdNumber;
        int correctEquation = firstNumber * (secondNumber - thirdNumber);
        Console.WriteLine(equation);
        Console.WriteLine(correctEquation);

        // challenge
        // note that (3 / 7) and (4 / 3) need to be converted to double. Do so by either
        // adding a 'd' after the number, or do 3.0 / 7.0
        double equation2 = ((3d / 7d) + Math.Pow(5, 2))/ (3 + (4d / 3d));
        Console.WriteLine(equation2);

        // increment and decrement
        firstNumber++;
        firstNumber--;

        // modulo
        int remainder = thirdNumber % secondNumber;
        Console.WriteLine(remainder);
    }
}