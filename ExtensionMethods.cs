// Extension Methods

// Allows us to add methods to an existing class without
// * Changing its source code
// * Creating a new class that inherits from it


internal static class StringExtension
{
    public static string Shorten(this string str, int length)
    {
        if (str.Length < length || str.Length <= 0)
        {
            throw new ArgumentOutOfRangeException("String length should be greater than the specified length");
        }

        var words = str.Split(" ");

        if (words.Length < length)
        {
            return str;
        }

        return string.Join(" ", words.Take(length)) + "...";
    }
}

class Program
{
    static void Main()
    {
        string str = "This is an amazing string and i loved it...";
        var modified = str.Shorten(5);
        Console.WriteLine(modified);
    }
}