//OVERFLOWING

// Every C# type has a MinValue and MaxValue that we can store
// - If we store a value that exceeds the type limit then overflow happens.

// Overflow Example
static void Main()
{
    byte b = 255; // limite 255
    b += 25; // Overflow happens

    byte b2 = 220;
    b2 += 2; // valid
}


// TYPE CONVERSION

static void TypeConversion()
{
    /*
        If types are compatible (integral and real nums) and the target type
        is bigger then the conversion automatically happens at runtime.
    */

    byte b = 1; // Source type 
    int i = b; // target type

    // Above valid -> byte < int and both are compatible (i.e) numbers;

    int a = 2000;
    byte b = a; // Error ( Cannot implicitly convert int to byte)

    byte c = (byte)a; // Explicit conversion (Causes overflow)

    /*IF types are not compatible */

    string s = "1234";
    int i = Convert.ToInt32(s); // We make use of convert class

}