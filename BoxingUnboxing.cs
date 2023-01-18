// Boxing
// Performance intensive
// The process of converting a value type instance to an object reference

void Main()
{
    int number = 10;
    object obj = number;

    // or
    object obj = 10;
}

// Unboxing
// The process of converting a reference type to an value type
void Main()
{
    object obj = 10;
    int number = (int)obj;
}