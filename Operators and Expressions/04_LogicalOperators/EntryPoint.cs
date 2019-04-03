using System;

class EntryPoint
{
    static void Main()
    {
        // && and, || or, ! not
        int number = 15;
        bool lessThan = number < 20;
        bool moreThan = number > 5;

        // reassign number variable
        number = 25;
        // be sure to recalculate boolean vars so isInRange returns correct result
        lessThan = number < 20;
        moreThan = number > 5;

        bool isInRange = lessThan && moreThan;
        Console.WriteLine(isInRange);

        // challenge. Check if longer than 6 chars and first char is capital
        string username = "customname66";
        int usernameLength = username.Length;
        char firstChar = username[0];
        int firstCharInt = (int)firstChar;
        bool firstCharIsCapitalLetter = firstCharInt >= 65 && firstCharInt <= 90;
        bool stringLongerThanSixChars = username.Length > 6;
        bool result = firstCharIsCapitalLetter && stringLongerThanSixChars;
        Console.WriteLine($"Challenge: {result}");

        // ternary: expression ? true_result : false_result
    }
}
