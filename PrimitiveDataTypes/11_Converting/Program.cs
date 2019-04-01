using System;

class Program
{
    static void Main()
    {
        // converting, parsing, and typecasting

        int number = 5;
        string word = "5";
        char x = 'x';
        float pi = 3.14f;

        // this works because there is no loss of information
        float integer = number;
        Console.WriteLine(integer);

        // this doesn't work, since int can't handle the extra information
        // int floating = pi;

        // so we can typecast it
        int floating = (int)pi;
        Console.WriteLine(floating);
        // typecasting only works if the two types are compatible (i.e. a number -> a number)

        // convert a string to integer with the Convert class in the system namespace
        int stringedInteger = Convert.ToInt32(word);
        Console.WriteLine(stringedInteger + 5);

        // parsing
        int parsedString = int.Parse(word);
        Console.WriteLine(parsedString);

        // diff between Convert and Parse...
        // if the string is null, Convert returns 0 and Parse returns an exception

    }
}