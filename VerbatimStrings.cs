// VERBATIM STRINGS

static void Main()
{

    // Problem
    string message = "Hi John\nLook at the following path:c:\\folder1\\folder2";

    // When there are multiple escape characters in a strings
    // it becomes hard to read and understand

    // Solution

    var message = @"Hi John
    Look at the following path:
    c:\folder1\folder2";

    // Cleaner approach
}