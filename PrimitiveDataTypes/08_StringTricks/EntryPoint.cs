using System;

class EntryPoint
{
    static void Main()
    {
        string fruitJuice = "strawberry juice";
        // does this string contain "f"? (method is case sensitive)
        Console.WriteLine(fruitJuice.Contains("f"));
        Console.WriteLine(fruitJuice.IndexOf("f")); // returns -1 (no match)
        Console.WriteLine(fruitJuice.IndexOf("r")); // 2
        Console.WriteLine(fruitJuice.LastIndexOf("berry")); // 5
        Console.WriteLine(fruitJuice.ToUpper().IndexOf("r")); // -1

        bool containsStraw = fruitJuice.ToLower().Contains("straw");
        Console.WriteLine(containsStraw);

        // generate strings of repeating characters
        string separator = "-------------------------";
        string dynamicSeparator = new string('-', 40);
        Console.WriteLine(dynamicSeparator);
    }
}
