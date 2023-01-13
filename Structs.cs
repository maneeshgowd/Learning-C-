// STRUCTS
// A struct is a type similar to a class.

// Few differences from class
/*
    -> cannot take null
    -> Dosen't have inheritance
    -> Implements interfaces
    -> Can have constructors but all fields should be initialized
    -> Members are public by default
*/

public struct Random
{
    public int value;

    public Random(int val)
    {
        value = val;
    }

    public void showData()
    {
        Console.WriteLine(value);
    }
}

// Use structs only when creating small lightweight objects.
// In .NET, all primitive types are declared as a structure. They are small and lightweight. 
// The biggest primitive type doesn’t take more than 16 bytes.