using System;

class EntryPoint
{
    static void Main()
    {
        Console.WriteLine(Addition(1, 4));
        Console.WriteLine(Addition(Addition(1, 4), Addition(5, 10)));

        int[] arrayResult = SortedNumbers(8, 64, 11);

        for (int i = 0; i < arrayResult.Length; i++)
        {
            Console.Write(arrayResult[i] + ", ");
        }
    }

    // must return the same data type specified in function definition
    static int Addition(int firstNum, int secondNum)
    {
        return firstNum + secondNum;
    }

    // sort three numbers in descending order
    static int[] SortedNumbers(int a, int b, int c)
    {
        int[] values = { a, b, c };

        if (a > b && a > c)
        {
            values.SetValue(a, 0);
            if (b > c)
            {
                values.SetValue(b, 1);
                values.SetValue(c, 2);
            }
            else
            {
                values.SetValue(c, 1);
                values.SetValue(b, 2);
            }
        }
        else if (b > a && b > c)
        {
            values.SetValue(b, 0);
            if (a > c)
            {
                values.SetValue(a, 1);
                values.SetValue(c, 2);
            }
            else
            {
                values.SetValue(c, 1);
                values.SetValue(a, 2);
            }
        }
        else
        {
            values.SetValue(c, 0);
            if (a > b)
            {
                values.SetValue(a, 1);
                values.SetValue(b, 2);
            }
            else
            {
                values.SetValue(b, 1);
                values.SetValue(a, 2);
            }
        }

        return values;
    }
}