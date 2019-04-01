using System;

class Program
{
    static void Main()
    {
        // building strings through placeholders and interpolation

        string nameOfCharacter = "Todd";
        int damageTaken = 100; // note that this is still an int until converted with toString()
        string spellName = "Fireball";

        // concatenation
        string damageReport = nameOfCharacter + " took " + damageTaken + " damage from " + spellName;
        Console.WriteLine(damageReport);

        // placeholders
        string damageReportV2 = string.Format("{0} took {1} damage from {2}", nameOfCharacter, damageTaken, spellName);
        Console.WriteLine(damageReportV2);

        // interpolation
        string damageReportV3 = $"{nameOfCharacter} took {damageTaken} damage from {spellName}";
        Console.WriteLine(damageReportV3);
    }
}
