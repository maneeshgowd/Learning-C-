// ENUMS

// Enumerated types (Named Constants)
// A data type that represents a set of name/value pairs.

namespace EnumTypes
{
    public enum Random
    {
        Name = 0,
        Age = 1,
        Year = 2
    }

    static void Main()
    {
        Enum en = Random.Name;

        // Enum - string

        Console.WriteLine(en.ToString());

        // Enum - int
        int age = (int)Random.Age;
        Console.WriteLine(age);

        // int - Enum
        Enum n = (Random)2;
        Console.WriteLine(n);

        // string - Enum
        Enum strEnum = (Random)Enum.Parse(typeof(Random), "Name");
        Console.WriteLine(strEnum);
    }
}