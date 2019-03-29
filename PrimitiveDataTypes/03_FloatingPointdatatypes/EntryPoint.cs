using System;

class EntryPoint
{
    static void Main()
    {
    // precision of 7 digits (this is the problem)
    float someFloatNumber = 31415151515f; // note f
    Console.WriteLine(someFloatNumber.ToString("f"));

    // area of a circle
    float radius = 3f; 
    float pi = 3.14f;
    float area = pi * radius * radius;
    Console.WriteLine(area);

    // 32 bit number, but with only 7 digits of precision
    float fMax = float.MaxValue;
    Console.WriteLine(fMax.ToString("f"));

    // 128 bit number, but with low precision (15 digits)
    double dVariable = 3.14d; // note d
    double doubleMax = double.MaxValue;
    double doubleMin = double.MinValue;
    Console.WriteLine(doubleMax);
    Console.WriteLine(doubleMin);

    // decimal has large precision (28 to 29 digits AND cuts off)
    decimal decValue = 142422536457.12312335352m; // note m
    decimal decimalMax = decimal.MaxValue;
    Console.WriteLine(decimalMax);
    }
}